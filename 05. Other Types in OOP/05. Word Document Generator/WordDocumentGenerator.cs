using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
			Formatting boldUnderlined = new Formatting {Bold = true, UnderlineStyle = UnderlineStyle.singleLine};

			intro.InsertText("\nSoftUni is organizing a contest for the best ");
			intro.InsertText("role playing game", false, bold);
			intro.InsertText(" from the OOP teamwork projects. The winning teams will receive a ");
			intro.InsertText("grand prize!", false, boldUnderlined);

			doc.InsertParagraph("\nThe game should be:");

			var listOfRequirements = doc.AddList(listType: ListItemType.Bulleted);
			doc.AddListItem(listOfRequirements, "Properly structured and follow all good OOP practices", 1);
			doc.AddListItem(listOfRequirements, "Awesome", 1);
			doc.AddListItem(listOfRequirements, "..Very Awesome", 1);
			doc.InsertList(listOfRequirements);

			doc.InsertParagraph();

			const int tableRows = 4;
			const int tableCols = 3;

			var table = doc.AddTable(tableRows, tableCols);

			table.Alignment = Alignment.center;
			table.Design = TableDesign.ColorfulListAccent3;

			table.Rows[0].Cells[0].Paragraphs.First().Append("Team");
			table.Rows[0].Cells[1].Paragraphs.First().Append("Game");
			table.Rows[0].Cells[2].Paragraphs.First().Append("Points");

			for (int row = 1; row < tableRows; row++)
			{
				for (int col = 0; col < tableCols; col++)
				{
					table.Rows[row].Cells[col].Paragraphs.First().Append("-");
				}
			}

			doc.InsertTable(table);

			Paragraph prizeParagraph = doc.InsertParagraph("\n");
			prizeParagraph.Alignment = Alignment.center;

			prizeParagraph.InsertText("The top 3 teams will receive a ");
			prizeParagraph.InsertText("SPECTACULAR", false, bold);
			prizeParagraph.InsertText(" prize:");

			Formatting bigPrizeFormatting = new Formatting
			{
				Bold = true,
				UnderlineStyle = UnderlineStyle.singleLine,
				FontColor = Color.FromArgb(12, 44, 85),
				Size = 28
			};

			var hugeParagraph = doc.InsertParagraph("A handshake from Nakov".ToUpper(), false, bigPrizeFormatting);
			hugeParagraph.Alignment = Alignment.center;

			doc.Save();

			Process.Start("winword.exe", @"..\..\file.docx");
		}
	}
}