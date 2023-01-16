//created by Amin Jalali, St.number : 973663044 Univercity of Isfahan, 01.16.2023

using System.Windows.Forms;

namespace SerialTerminal.Codes
{
    internal static class UIUtility
    {
        // Drop Down (Combo Box)
        public static void FillDropDownValues(ComboBox dropDown, string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                dropDown.Items.Add(values[i]);
            }
        }

        public static ComboBox.ObjectCollection GetDropDownValues(ComboBox dropDown)
        {
            return dropDown.Items;
        }

        public static void RefreshDropDown(ComboBox dropDown)
        {
            dropDown.Items.Clear();
        }
        //

        public static void AddInputToHistory(ListBox historyList, string input)
        {
            historyList.Items.Add(input);
        }

        public static void ClearHistory(ListBox historyList)
        {
            historyList.Items.Clear();
        }
    }
}
