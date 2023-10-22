using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FpAssistantCore;
using FpAssistantCore.General;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FPAssistantSampleAppWf.Forms.General
{
    public partial class ConversionsForm : Form
    {
        public ConversionsForm()
        {
            InitializeComponent();
            TextBoxNm.Text = "1";
            ConvertFromNm();
        }

        private bool skipTextChangedEvent = false;

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxNm_TextChanged(object sender, EventArgs e)
        {
            if (skipTextChangedEvent == true)
            {
                return;
            }
            ConvertFromNm();
        }

        private void ConvertFromNm()
        {
            (bool status, double nm) = (Utilities.ConvertStringToDouble(TextBoxNm.Text));
            if (status)
            {
                LinearDistance linearDistance = new(nm, LinearDistanceUnits.NM);

                skipTextChangedEvent = true;
                TextBoxKm.Text = linearDistance.ConvertTo(LinearDistanceUnits.KM).ToString(LinearDistanceFormat.InternalPrecision);
                TextBoxFeet.Text = linearDistance.ConvertTo(LinearDistanceUnits.Feet).ToString(LinearDistanceFormat.InternalPrecision);
                TextBoxMetres.Text = linearDistance.ConvertTo(LinearDistanceUnits.Metres).ToString(LinearDistanceFormat.InternalPrecision);
                skipTextChangedEvent = false;
            }
        }

        private void TextBoxKm_TextChanged(object sender, EventArgs e)
        {
            if (skipTextChangedEvent == true)
            {
                return;
            }

            (bool status, double km) = (Utilities.ConvertStringToDouble(TextBoxKm.Text));
            if (status)
            {
                LinearDistance linearDistance = new(km, LinearDistanceUnits.KM);

                skipTextChangedEvent = true;
                TextBoxNm.Text = linearDistance.ConvertTo(LinearDistanceUnits.NM).ToString(LinearDistanceFormat.InternalPrecision);
                TextBoxFeet.Text = linearDistance.ConvertTo(LinearDistanceUnits.Feet).ToString(LinearDistanceFormat.InternalPrecision);
                TextBoxMetres.Text = linearDistance.ConvertTo(LinearDistanceUnits.Metres).ToString(LinearDistanceFormat.InternalPrecision);
                skipTextChangedEvent = false;
            }
        }

        private void TextBoxFeet_TextChanged(object sender, EventArgs e)
        {
            if (skipTextChangedEvent == true)
            {
                return;
            }

            (bool status, double feet) = (Utilities.ConvertStringToDouble(TextBoxFeet.Text));
            if (status)
            {
                LinearDistance linearDistance = new(feet, LinearDistanceUnits.Feet);

                skipTextChangedEvent = true;
                TextBoxNm.Text = linearDistance.ConvertTo(LinearDistanceUnits.NM).ToString(LinearDistanceFormat.InternalPrecision);
                TextBoxKm.Text = linearDistance.ConvertTo(LinearDistanceUnits.KM).ToString(LinearDistanceFormat.InternalPrecision);
                TextBoxMetres.Text = linearDistance.ConvertTo(LinearDistanceUnits.Metres).ToString(LinearDistanceFormat.InternalPrecision);
                skipTextChangedEvent = false;
            }
        }

        private void TextBoxMetres_TextChanged(object sender, EventArgs e)
        {
            if (skipTextChangedEvent == true)
            {
                return;
            }

            (bool status, double metres) = (Utilities.ConvertStringToDouble(TextBoxMetres.Text));
            if (status)
            {
                LinearDistance linearDistance = new(metres, LinearDistanceUnits.Metres);

                skipTextChangedEvent = true;
                TextBoxNm.Text = linearDistance.ConvertTo(LinearDistanceUnits.NM).ToString(LinearDistanceFormat.InternalPrecision);
                TextBoxKm.Text = linearDistance.ConvertTo(LinearDistanceUnits.KM).ToString(LinearDistanceFormat.InternalPrecision);
                TextBoxFeet.Text = linearDistance.ConvertTo(LinearDistanceUnits.Feet).ToString(LinearDistanceFormat.InternalPrecision);
                skipTextChangedEvent = false;
            }
        }
    }
}
