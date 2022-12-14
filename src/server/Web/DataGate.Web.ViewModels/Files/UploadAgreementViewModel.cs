// Copyright (c) DataGate Project. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DataGate.Web.ViewModels.Files
{
    using System;

    using Microsoft.AspNetCore.Http;

    public class UploadAgreementViewModel
    {
        public string ControllerName { get; set; }

        public string AgrType { get; set; }

        public DateTime ContractDate { get; set; }

        public DateTime ActivationDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string Company { get; set; }

        public string Status { get; set; }

        public IFormFile FileToUpload { get; set; }
    }
}
