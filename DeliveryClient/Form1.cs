using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryClient.DTOs;

namespace DeliveryClient
{
    public partial class Form1 : Form
    {
        private DeliveryApi _deliveryApi => new DeliveryApi(new Uri(siteUriTextBox.Text));
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void registerCargoButton_Click(object sender, EventArgs e)
        {
            if (registerCargoRadioButton.Checked)
            {
                guidTextBox.Text = _deliveryApi.RegisterTicket(new RegisterTicketDto()
                {
                    CustomerName = customerName.Text,
                    Description = descriptionRichTextBox.Text,
                    WeightKg = decimal.Parse(descriptionRichTextBox.Text),
                    СargoСollectionTime = сargoСollectionTimeDateTimePicker.Value,
                }).Id.ToString();
            }
            
            if (updateCargoRadioButton.Checked)
            {
                _deliveryApi.UpdateTicket(new UpdateTicketDto()
                {
                    Id = Guid.Parse(guidTextBox.Text),
                    CustomerName = customerName.Text,
                    Description = descriptionRichTextBox.Text,
                    WeightKg = decimal.Parse(descriptionRichTextBox.Text),
                    СargoСollectionTime = сargoСollectionTimeDateTimePicker.Value,
                });
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _deliveryApi.CancelTicket(new CancelTicketDto()
            {
                Id = Guid.Parse(cancelIdTextBox.Text),
                Reason = cancelReasonTextBox.Text
            });
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (fullTextSearchRadioButton.Checked)
            {
                dataGridView1.DataSource = _deliveryApi.SearchTickets(searchTextBox.Text);
            }
            if (searchIdRadioButton.Checked)
            {
                dataGridView1.DataSource = new TicketDto[1] { _deliveryApi.GetTicket(Guid.Parse(searchTextBox.Text)) };
            }
        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            var guidDto = new GuidDto()
            {
                Id = Guid.Parse(courierMenuGuidTextBox.Text),
            };

            if (takeInWorkRadioButton.Checked)
            {
                _deliveryApi.TakeTicketInWork(guidDto);
            }
            if (checkAsDoneRadioButton.Checked)
            {
                _deliveryApi.DoneTicket(guidDto);
            }
        }

        private void getAllTicketsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _deliveryApi.GetTickets();
        }

        private void getNewTicketsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _deliveryApi.GetNewTickets();
        }

        private void registerCargoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guidTextBox.ReadOnly = registerCargoRadioButton.Checked;
        }
    }
}
