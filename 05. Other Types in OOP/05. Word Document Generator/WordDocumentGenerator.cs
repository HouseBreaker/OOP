using System;
using System.Diagnostics;
using Novacode;

namespace _05.Word_Document_Generator
{
	class WordDocumentGenerator
	{
		static void Main()
		{
			var doc = DocX.Create(@"..\..\file.docx");
			var resourcesFolder = @"..\..\res\";

			Formatting titleFormatting = new Formatting {Bold = true, Size = 28};
			Paragraph title = doc.InsertParagraph("SoftUni OOP Game Contest", false, titleFormatting);
			title.Alignment = Alignment.center;

			Paragraph pic = doc.InsertParagraph();
			pic.Alignment = Alignment.center;

			Picture rpgPicture = doc.AddImage(resourcesFolder + "rpg-game.png").CreatePicture(216, 606);
			pic.AppendPicture(rpgPicture);

			Paragraph intro = doc.InsertParagraph();
			Formatting bold = new Formatting {Bold = true};
			Formatting boldUnderlined = new Formatting { Bold = true, UnderlineStyle = UnderlineStyle.singleLine};

			intro.InsertText("\nSoftUni is organizing a contest for the best ");
			intro.InsertText("role playing game", false, bold);
			intro.InsertText(" from the OOP teamwork projects. The winning teams will receive a ");
			intro.InsertText("grand prize!", false, boldUnderlined);

			doc.InsertParagraph("\nThe game should be:");
			
			//doc.InsertList();

			doc.Save();

			Process.Start("winword.exe", @"..\..\file.docx");
		}
	}
}