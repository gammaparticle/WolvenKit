using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WolvenKit.Controls
{
    /// <summary>
    /// Interaction logic for AddPathDialogView.xaml
    /// </summary>
    public partial class PathEditorView
    {
        private readonly bool _isFolderPicker;
        private readonly bool _multiselect;

        public PathEditorView(bool isFolderPicker, bool multiselect)
        {
            InitializeComponent();

            _isFolderPicker = isFolderPicker;
            _multiselect = multiselect;
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            nameof(Text), typeof(string), typeof(PathEditorView), new PropertyMetadata(""));

        private HandyControl.Data.OperationResult<bool> VerifyFile(string str)
        {
            if (_isFolderPicker)
            {
                if (System.IO.Directory.Exists(str))
                {
                    notification.SetCurrentValue(System.Windows.Controls.Primitives.Popup.IsOpenProperty, false);
                    return HandyControl.Data.OperationResult.Success();
                }

                return HandyControl.Data.OperationResult.Failed();
            }
            else
            {
                if (System.IO.File.Exists(str))
                {
                    notification.SetCurrentValue(System.Windows.Controls.Primitives.Popup.IsOpenProperty, false);
                    return HandyControl.Data.OperationResult.Success();
                }

                return HandyControl.Data.OperationResult.Failed();
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = true,
                Multiselect = _multiselect,
                IsFolderPicker = _isFolderPicker,

                Title = "Select files or folders"
            };
            if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var results = dlg.FileNames;
            if (results == null)
            {
                return;
            }


            SetCurrentValue(TextProperty, "");
            foreach (var s in results)
            {
                if (_multiselect)
                {
                    Text += $"\"{s}\";";
                }
                else
                {
                    SetCurrentValue(TextProperty, s);
                }
            }
        }
    }
}
