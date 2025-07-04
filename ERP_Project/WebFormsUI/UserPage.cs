using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.NetworkInformation;



namespace WebFormsUI
{
    public partial class UserPage : Form
    {


        private IUserScreenService _userScreenService;
        private IUserService _userService;
        private IScreenService _screenService;
        private Dictionary<string, Type> screenForms;


        public UserPage()
        {
            InitializeComponent();

            _userScreenService = new UserScreenManager(new UserScreenDal());
            _userService = new UserManager(new UserDal());
            _screenService = new ScreenManager(new ScreenDal());
            screenForms = new Dictionary<string, Type>();
            btnGo.Click += btnGo_Click;

        }

        private void PopulateScreenFormsDictionary()
        {
            try
            {
                foreach (var item in cbxChooseScreen.Items)
                {
                    var screenItem = item as dynamic;

                    if (screenItem != null)
                    {
                        string screenName = screenItem.ScreenName;
                        string formTypeName = screenName;

                        var assembly = Assembly.GetExecutingAssembly();

                        Type formType = assembly.GetType($"WebFormsUI.{formTypeName}");

                        if (formType != null && formType.IsSubclassOf(typeof(Form)))
                        {
                            screenForms[screenName] = formType;
                        }
                        else
                        {
                            MessageBox.Show($"Form type for {screenName} not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item in ComboBox is not in the expected format.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void UserPage_Load(object sender, EventArgs e)
        {
            try
            {
                var user = _userService.GetUserListByUserId(SessionManager.LoggedInUserId);
                LoadAuthorizedScreens();
                PopulateScreenFormsDictionary();
                foreach (var detail in user)
                {
                    lblDateTime.Text = DateTime.Now.ToString();
                    lblUser.Text = detail.Name + " " + detail.Surname;
                    lblDepartment.Text = detail.Department.DepartmentName;
                    lblRole.Text = detail.Role.RoleName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void LoadAuthorizedScreens()
        {
            try
            {
                int userId = SessionManager.LoggedInUserId;
                var authorizedScreens = _userScreenService.ShowAuthorizedScreens(userId);
                if (authorizedScreens == null || !authorizedScreens.Any())
                {
                    MessageBox.Show("No authorized screens found.");
                    return;
                }
                var screenList = authorizedScreens
        .Where(x => x.Screen != null)
        .Select(x => new
        {
            ScreenName = x.Screen.ScreenName,
            ScreenId = x.Screen.ScreenId
        })
        .ToList();
                cbxChooseScreen.DataSource = screenList;
                cbxChooseScreen.DisplayMember = "ScreenName";
                cbxChooseScreen.ValueMember = "ScreenId";

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = cbxChooseScreen.SelectedItem;

                if (selectedItem != null)
                {
                    var screenNameProperty = selectedItem.GetType().GetProperty("ScreenName");

                    if (screenNameProperty != null)
                    {
                        string selectedScreenName = screenNameProperty.GetValue(selectedItem)?.ToString();

                        if (screenForms.ContainsKey(selectedScreenName))
                        {
                            Form screenForm = (Form)Activator.CreateInstance(screenForms[selectedScreenName]);

                            screenForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Unknown screen selected or form not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unable to retrieve ScreenName from the selected item.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a screen from the list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}













