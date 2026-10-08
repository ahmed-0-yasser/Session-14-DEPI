namespace Library_Management_System.Models;

public class Loan
{
    public int BookId { get; set; }
    public int BorrowerId { get; set; }

    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public Book Book { get; set; }
    public Borrower Borrower { get; set; }
}