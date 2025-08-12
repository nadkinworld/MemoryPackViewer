using System.Reflection;
using System.Text.Json;
using MemoryPack;

namespace MemoryPackViewer
{
    public partial class Form1 : Form
    {
        private readonly List<(string DisplayName, Type ModelType)> _models
            = new List<(string, Type)>
        {
            ("UserPermission", typeof(UserPermission)),
            ("DeviceUserRM", typeof(DeviceUserRM)),
        };

        public Form1()
        {
            InitializeComponent();

            // پر کردن ComboBox
            foreach (var m in _models)
                comboModels.Items.Add(m.DisplayName);

            if (comboModels.Items.Count > 0)
                comboModels.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = comboModels.SelectedIndex;
                if (selectedIndex < 0)
                {
                    MessageBox.Show("مدلی انتخاب نشده است.");
                    return;
                }

                var modelType = _models[selectedIndex].ModelType;
                var binaryString = txtData.Text.Trim();

                var data = BinaryStringToBytes(binaryString);

                var obj = MemoryPackHelper.Deserialize(modelType, data);

                var json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
                txtOutput.Text = json;
            }
            catch (Exception ex)
            {
                txtOutput.Text = "Error: " + ex.Message;
            }
        }
        private static byte[] BinaryStringToBytes(string binary)
        {
            binary = binary.Replace(" ", "").Replace("\n", "").Replace("\r", "");

            int byteCount = binary.Length / 8;
            byte[] bytes = new byte[byteCount];

            for (int i = 0; i < byteCount; i++)
            {
                string byteString = binary.Substring(i * 8, 8);
                bytes[i] = Convert.ToByte(byteString, 2);
            }

            return bytes;
        }

    }

    [MemoryPackable]
    public partial class DeviceUserRM
    {
        public uint Code { get; set; }
        public uint DeviceId { get; set; }
        public Guid Id { get; set; }
        public int AdminLevel { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public int AuthMode { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public bool IsActive { get; set; }
        public int IdentityCardsCount { get; set; }
        public int FaceTemplatesCount { get; set; }
        public int FingerTemplatesCount { get; set; }
        public bool IsAdmin { get; set; }
        public string? Description { get; set; }
    }


    [MemoryPackable]
    public partial class UserPermission
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<string> Permissions { get; set; } = new();
        public DateTime CachedAt { get; set; } = DateTime.UtcNow;
    }
}
