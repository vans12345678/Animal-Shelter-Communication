// File: ErrorViewModel.cs
// Name: Andre Agrippa
// Date: 12/10/2020
// Purpose: Error View Model

using System;

namespace Animal_Shelter_Lab6.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
