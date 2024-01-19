namespace MoveInatorForms.Utilities.Extensions
{
    public static class ControlExtensions
    {
        public static void ResetCheckedList(this CheckedListBox checkedListBox, int index = -1)
        {
            foreach (int ind in checkedListBox.CheckedIndices)
            {
                if (ind != index)
                    checkedListBox.SetItemChecked(ind, false);
            }
        }

        public static void ReloadBindingSource<T>(this ComboBox comboBox, BindingSource bindingSource, string displayName, string property = null) where T : class
        {
            var old = default(T);

            if (comboBox.SelectedItem is not null &&
                comboBox.SelectedItem is T entity)
            {
                bindingSource.ResetCurrentItem();
                old = entity;
            }

            comboBox.DataSource = null;
            comboBox.DataSource = bindingSource;
            comboBox.DisplayMember = displayName;

            if (old is not null && !string.IsNullOrEmpty(property))
            {
                var propertyInfo = typeof(T).GetProperty(property) ?? throw new Exception($"Não foi encontrado a propriedade: '{property}' em {typeof(T).Name}");
                var oldValue = propertyInfo.GetValue(old);

                comboBox.SelectedItem = bindingSource.OfType<T>().FirstOrDefault(x => propertyInfo.GetValue(x) == oldValue);
            }
            else
            {
                comboBox.SelectedItem = bindingSource.OfType<T>().FirstOrDefault();
            }
        }

        public static void FillSpecificCells(this DataGridView grid, params string[] cells)
        {
            var columns = grid.Columns.OfType<DataGridViewColumn>().ToList();

            foreach (var cellName in cells)
            {
                var cell = columns.FirstOrDefault(x => x.DataPropertyName == cellName);

                if (cell is null)
                    continue;

                cell.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
