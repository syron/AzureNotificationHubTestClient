using Microsoft.Azure.NotificationHubs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WISPushNoticationsTestClient.Exceptions;

namespace WISPushNoticationsTestClient
{
    public partial class Form1 : Form
    {
        NotificationHubClient client = null;
        
        List<Microsoft.Azure.NotificationHubs.GcmTemplateRegistrationDescription> googlePhones = new List<GcmTemplateRegistrationDescription>();
        List<Microsoft.Azure.NotificationHubs.AppleTemplateRegistrationDescription> applePhones = new List<AppleTemplateRegistrationDescription>();
        List<Microsoft.Azure.NotificationHubs.WindowsTemplateRegistrationDescription> windowsPhones = new List<Microsoft.Azure.NotificationHubs.WindowsTemplateRegistrationDescription>();
        List<Microsoft.Azure.NotificationHubs.RegistrationDescription> unknownPhones = new List<RegistrationDescription>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            buttonRefresh.Enabled = false;
            try
            {
                client = NotificationHubClient.CreateClientFromConnectionString(textBoxConnectionString.Text, textBoxHubName.Text);
                LoadRegistrations();
                panel1.Enabled = true;
                buttonRefresh.Enabled = true;
            }
            catch (LoadRegistrationsException rex)
            {
                MessageBox.Show($"Coud not load registrations. Exception: {rex.ToString()}", "Load Registrations Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not connect to Azure Notifications Hub. Excpetion: {ex.ToString()}", "Connection Error", MessageBoxButtons.OK);
            }
        }

        private void LoadRegistrations()
        {
            googlePhones.Clear();
            windowsPhones.Clear();
            applePhones.Clear();
            unknownPhones.Clear();

            DALLoadRegistrations();

            labelApplePhones.Text = applePhones.Count.ToString();
            labelWindowsPhones.Text = windowsPhones.Count.ToString();
            labelGooglePhones.Text = googlePhones.Count.ToString();
            labelUnknownPhones.Text = unknownPhones.Count.ToString();
        }

        private void DALLoadRegistrations()
        {
            try
            {
                var t_registrations = client.GetAllRegistrationsAsync(100);

                t_registrations.Wait();
                Microsoft.Azure.NotificationHubs.CollectionQueryResult<Microsoft.Azure.NotificationHubs.RegistrationDescription> registrations = t_registrations.Result;

                foreach (var reg in registrations)
                {
                    if (reg.GetType() == typeof(Microsoft.Azure.NotificationHubs.GcmTemplateRegistrationDescription))
                    {
                        googlePhones.Add((Microsoft.Azure.NotificationHubs.GcmTemplateRegistrationDescription)reg);
                    }
                    else if (reg.GetType() == typeof(Microsoft.Azure.NotificationHubs.AppleTemplateRegistrationDescription))
                    {
                        applePhones.Add((Microsoft.Azure.NotificationHubs.AppleTemplateRegistrationDescription)reg);
                    }
                    else if (reg.GetType() == typeof(Microsoft.Azure.NotificationHubs.WindowsTemplateRegistrationDescription))
                    {
                        windowsPhones.Add((Microsoft.Azure.NotificationHubs.WindowsTemplateRegistrationDescription)reg);
                    }
                    else
                    {
                        unknownPhones.Add(reg);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new LoadRegistrationsException(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonApple_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBoxApple();
        }

        private void UpdateListBoxApple()
        {
            if (radioButtonApple.Checked)
            {
                listBoxRegistrations.Items.Clear();
                foreach (var regs in applePhones)
                {
                    var tags = regs.Tags.ToArray<string>();

                    var unit = String.Join("&&", tags[1], tags[0]);
                    listBoxRegistrations.Items.Add(unit);
                }
            }
        }

        private void radioButtonGoogle_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBoxGoogle();
        }

        private void UpdateListBoxGoogle()
        {
            if (radioButtonGoogle.Checked)
            {
                listBoxRegistrations.Items.Clear();
                foreach (var regs in googlePhones)
                {
                    var tags = regs.Tags.ToArray<string>();

                    var unit = String.Join("&&", tags[1], tags[0]);
                    listBoxRegistrations.Items.Add(unit);
                }
            }
        }

        private void radioButtonWindows_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBoxWindows();
        }

        private void UpdateListBoxWindows()
        {
            if (radioButtonWindows.Checked)
            {
                listBoxRegistrations.Items.Clear();
                foreach (var regs in windowsPhones)
                {
                    var tags = regs.Tags.ToArray<string>();

                    var unit = String.Join("&&", tags[1], tags[0]);
                    listBoxRegistrations.Items.Add(unit);
                }
            }
        }

        private void radioButtonUknown_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBoxUnknown();
        }

        private void UpdateListBoxUnknown()
        {
            if (radioButtonUknown.Checked)
            {
                listBoxRegistrations.Items.Clear();
                foreach (var regs in unknownPhones)
                {
                    var tags = regs.Tags.ToArray<string>();

                    var unit = String.Join("&&", tags[1], tags[0]);
                    listBoxRegistrations.Items.Add(unit);
                }
            }
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            panel1.Enabled = false;
            try
            {
                LoadRegistrations();
                panel1.Enabled = true;

                if (radioButtonApple.Checked)
                {
                    UpdateListBoxApple();
                }
                else if (radioButtonGoogle.Checked)
                {
                    UpdateListBoxGoogle();
                }
                else if (radioButtonWindows.Checked)
                {
                    UpdateListBoxWindows();
                }
                else
                {
                    UpdateListBoxUnknown();
                }
            }
            catch (LoadRegistrationsException rex)
            {
                MessageBox.Show($"Coud not load registrations. Exception: {rex.ToString()}", "Load Registrations Error", MessageBoxButtons.OK);
            }
        }

        private void buttonSendPush_Click(object sender, EventArgs e)
        {
            var message = textBoxSendPushText.Text;
            var toAddress = listBoxRegistrations.SelectedItem;

            if (toAddress == null || string.IsNullOrWhiteSpace(toAddress.ToString()))
            {
                MessageBox.Show("Please select a receiver from the above list.", "Error sending push", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Message must not be empty or null.", "Error sending push", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var t_send = Send(this.client, toAddress.ToString(), message, message);
                MessageBox.Show("Push message has been sent.", "Push sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Sends push notification.
        /// </summary>
        /// <param name="hub">The notification hub client to use.</param>
        /// <param name="toAddress">The receiving address.</param>
        /// <param name="body">Push body.</param>
        /// <param name="badge">Text to show in badge.</param>
        /// <returns>Async Task</returns>
        public async Task Send(NotificationHubClient hub, string toAddress, string body, string badge)
        {
            try
            {
                if (hub != null)
                {
                    var notification = new Dictionary<string, string> { { "message", body }, { "badge", badge } };
                    await hub.SendTemplateNotificationAsync(notification, toAddress);
                }
            }
            catch (Exception ex)
            {
                var mess = ex.Message;
            }
        }

        private void listBoxRegistrations_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var t_registrations = client.GetAllRegistrationsAsync(100);

                t_registrations.Wait();
                Microsoft.Azure.NotificationHubs.CollectionQueryResult<Microsoft.Azure.NotificationHubs.RegistrationDescription> registrations = t_registrations.Result;


                var selectedItem = listBoxRegistrations.SelectedItem.ToString();
                var tags = selectedItem.Split('&', '&');

                var registration = registrations.FirstOrDefault(r => r.Tags.ToArray()[0] == tags[2] && r.Tags.ToArray()[1] == tags[0]);

                DialogResult msgBox = MessageBox.Show("Are you sure you want to delete this registration?", "Are you sure?", MessageBoxButtons.OKCancel);
                if (DialogResult.OK == msgBox)
                {
                    var t_delete = client.DeleteRegistrationAsync(registration);
                    t_delete.Wait();
                }

                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting registration. Exception: {ex.ToString()}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
