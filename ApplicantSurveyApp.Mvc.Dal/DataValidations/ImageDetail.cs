using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace ApplicantSurveyApp.Mvc.Dal {

    [MetadataType(typeof(ImageDetailMetaData))]
    public partial class ImageDetail { }

	public class ImageDetailMetaData {
		public int ImageID { get; set; }
		public string Location { get; set; }
		public string Comment { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
	}
}
