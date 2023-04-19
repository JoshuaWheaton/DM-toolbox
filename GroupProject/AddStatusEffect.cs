using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class AddStatusEffect : Form
    {
        public AddStatusEffect()
        {
            InitializeComponent();
        }

        //Function to create a status effect object when the AddStatus button is clicked
        private void AddStatusButton_Click(object sender, EventArgs e)
        {
            mainGUI parentForm = (mainGUI)this.Owner;
            //Bool declarations
            bool sot = false, eot = false, onDmg = false, blinded = false, charmed = false,
                 deafened = false, frightened = false, grappled = false, incapacitated = false,
                 invisible = false, paralyzed = false, petrified = false, poisoned = false,
                 prone = false, restrained = false, stunned = false, unconscious = false;

            //Get name from form
            string name = StatusNameBox.Text;

            //Get duration from form
            byte duration = (byte)StatusDuration.Value;

            //Get Save DC and type from form
            byte saveDC = (byte)SaveDCBox.Value;
            string saveType = SaveStatBox.Text;

            //Get Saving Throw conditions from form
            if (SvStartOfTurn.Checked)
            { sot = true; }
            if (SvEndOfTurn.Checked)
            { eot = true; }
            if (SvOnDmg.Checked)
            { onDmg = true; }

            //Test OtherEffects Box
            string otherEffects = OtherEffectsBox.Text;

            //Test Condition Checkboxes
            if (Blinded.Checked)
            { blinded = true; }
            if (Charmed.Checked)
            { charmed = true; }
            if (Deafened.Checked)
            { deafened = true; }
            if (Frightened.Checked)
            { frightened = true; }
            if (Grappled.Checked)
            { grappled = true; }
            if (Incapacitated.Checked)
            { incapacitated = true; }
            if (Invisible.Checked)
            { invisible = true; }
            if (Paralyzed.Checked)
            { paralyzed = true; }
            if (Petrified.Checked)
            { petrified = true; }
            if (Poisoned.Checked)
            { poisoned = true; }
            if (Prone.Checked)
            { prone = true; }
            if (Restrained.Checked)
            { restrained = true; }
            if (Stunned.Checked)
            { stunned = true; }
            if (Unconscious.Checked)
            { unconscious = true; }

            //Call constructor
            StatusEffect newEffect = new StatusEffect(name, duration, sot, eot, onDmg, saveType, saveDC, otherEffects, blinded,
                                                      charmed, deafened, frightened, grappled, incapacitated,
                                                      invisible, paralyzed, petrified, poisoned, prone,
                                                      restrained, stunned, unconscious);

            //Add to status list
            parentForm.AddtoStatusList(newEffect);
            this.Close();
        }
    }
}
