using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace FINALPROJECTCSC323.NewFolder;

public class INVOICE
{
    public string? RestaurantName { get; set; }
    public string? CustomerName { get; set; }
    public DateTime IssueDate { get; set; }
    public decimal Tax { get; set; } = 0.1m;

    public decimal DiscountAmount { get; set; }
    public decimal TotalAmount { get; set; }

    public decimal FinalAmount { get; set; }
    public List<INVOICELINE> InvoiceLines { get; set; } = new List<INVOICELINE>();
    public PAYMENT? Payment { get; set; }

    public INVOICE() { }
    public void AddInvoiceLine(INVOICELINE line)
    {

        InvoiceLines.Add(line);

    }

    public void CalculateFinalAmount()
    {

        FinalAmount = TotalAmount * (1 + Tax);
    }

    public string printinvoice()
    {

        var sb = new StringBuilder();
        sb.AppendLine($"INVOICE - {RestaurantName}");
        sb.AppendLine($"Date: {IssueDate:yyyy-MM-dd}");
        sb.AppendLine($"Customer: {CustomerName}");
        sb.AppendLine("------------------------------");

        foreach (var line in InvoiceLines)
        {
            sb.AppendLine($"{line.ItemName} QTY: {line.Quantity}   {line.UnitPrice} $   {line.Subtotal} $");
        }


        sb.AppendLine("------------------------------");

        sb.AppendLine($"Total: {TotalAmount:0.00} $  ({DiscountAmount * 100}% Discount)");

        sb.AppendLine($"FinalTotal: {FinalAmount:0.00} $");


        return sb.ToString();
    }

}