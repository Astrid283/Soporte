using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_IIParcial
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        SoporteForm _soporteForm = null;
        TicketsForm _ticketForm = null;

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (_soporteForm == null)
            {
                _soporteForm = new SoporteForm();
                _soporteForm.MdiParent = this;
                _soporteForm.FormClosed += _soporteForm_FormClosed;
                _soporteForm.Show();
            }
            else
            {
                _soporteForm.Activate();
            }
        }

        private void _soporteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _soporteForm = null;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (_ticketForm == null)
            {
                _ticketForm = new TicketsForm();
                _ticketForm.MdiParent = this;
                _ticketForm.FormClosed += _ticketForm_FormClosed;
                _ticketForm.Show();
            }
            else
            {
                _ticketForm.Activate();
            }
        }

        private void _ticketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ticketForm = null;
        }
    }
}
