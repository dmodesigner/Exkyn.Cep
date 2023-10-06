using Aspose.Cells;
using System.Data;

var files = new List<string>();
files.Add("Estado.xlsx");
//files.Add("Cidade.xlsx");
//files.Add("Bairro.xlsx");
//files.Add("Endereço.xlsx");

foreach (var file in files)
{
    var dt = ConvertExcelInDataTable(file);

    //Validar os dados da planilha gerada (sempre que necessario
    //Chamar a API para fazer o insert dos dados na  base de dados
}

DataTable ConvertExcelInDataTable(string file)
{
    const string path = "C:\\Projetos\\Exkyn.Cep\\Batch\\CreateBase\\Files\\";

    Workbook excel = new Workbook(path + file);

    if (excel == null)
        throw new ArgumentException("O arquivo da planilha importada não foi encontrada.");

    Worksheet sheet = excel.Worksheets[0];

    if (sheet == null)
        throw new ArgumentException("Não foi encontrado nenhuma aba na planilha.");

    DataTable dt = sheet.Cells.ExportDataTable(0, 0, (sheet.Cells.MaxRow + 1), (sheet.Cells.MaxColumn + 1), true);
    dt.TableName = sheet.Name;

    return dt;
}

