using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobTriggerFunction
{

        public class BlobDetails
        {
            public Guid Id { get; set; }
            public string FileName { get; set; }
            public bool isFileUploaded { get; set; }
            public DateTime DateOfUpdation { get; set; }
        }

}
