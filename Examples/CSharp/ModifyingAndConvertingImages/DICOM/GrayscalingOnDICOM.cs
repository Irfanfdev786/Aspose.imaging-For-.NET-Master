﻿using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/


namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class GrayscalingOnDICOM
    {
        public static void Run()
        {
            //ExStart:GrayscalingOnDICOM
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            Console.WriteLine("Running example GrayscalingOnDICOM");
            using (var fileStream = new FileStream(dataDir + "file.dcm", FileMode.Open, FileAccess.Read))
            using (DicomImage image = new DicomImage(fileStream))
            {
                // Transform image to its grayscale representation and Save the resultant image.
                image.Grayscale();
                image.Save(dataDir + "GrayscalingOnDICOM_out.bmp", new BmpOptions());
            }

            Console.WriteLine("Finished example GrayscalingOnDICOM");
            //ExEnd:GrayscalingOnDICOM
        }
    }
}