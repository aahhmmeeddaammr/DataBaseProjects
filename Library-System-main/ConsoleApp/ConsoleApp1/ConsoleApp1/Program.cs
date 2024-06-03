// See https://aka.ms/new-console-template for more information


using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Console.Write("Please select which operation you would like to execute: " + Environment.NewLine +
                              "1- Add a new book" + Environment.NewLine +
                              "2- Delete a book" + Environment.NewLine +
                              "3- Ask for the availability of a book" + Environment.NewLine +
                              "4- Borrow a book" + Environment.NewLine +
                              "5- Ask for the category name of a book" + Environment.NewLine +
                              "6- Sign up" + Environment.NewLine +
                              "7- Change password" + Environment.NewLine);

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                }

                switch (choice)
                {
                    case 1:
                        InsertBook(connection);
                        break;
                    case 2:
                        DeleteBook(connection);
                        break;
                    case 3:
                        SelectBookCopies(connection);
                        break;
                    case 4:
                        UpdateCopiesOfBook(connection);
                        break;
                    case 5:
                        SelectBooksAndTheirCategories(connection);
                        break;
                    case 6:
                        InsertNewMember(connection);
                        break;
                    case 7:
                        UpdatePassword(connection);
                        break;
                }

                connection.Close();
            }
        }
        static void InsertBook(SqlConnection connection)
        {
            Console.Write("Adding a book " + Environment.NewLine);
            Console.Write("Enter ISBN: ");
            int ISBN;
            while (!int.TryParse(Console.ReadLine(), out ISBN))
            {
                Console.WriteLine("Invalid input. Please enter a valid ISBN.");
                Console.Write("Enter ISBN: ");
            }

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Price: ");
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid input. Please enter a valid price.");
                Console.Write("Enter Price: ");
            }

            Console.Write("Enter Summary: ");
            string summary = Console.ReadLine();

            Console.Write("Enter Publication Year: ");
            int pYear;
            while (!int.TryParse(Console.ReadLine(), out pYear))
            {
                Console.WriteLine("Invalid input. Please enter a valid publication year.");
                Console.Write("Enter Publication Year: ");
            }

            Console.Write("Enter Edition: ");
            int edition;
            while (!int.TryParse(Console.ReadLine(), out edition))
            {
                Console.WriteLine("Invalid input. Please enter a valid edition.");
                Console.Write("Enter Edition: ");
            }

            Console.Write("Enter Number of Copies: ");
            int copiesNo;
            while (!int.TryParse(Console.ReadLine(), out copiesNo))
            {
                Console.WriteLine("Invalid input. Please enter a valid number of copies.");
                Console.Write("Enter Number of Copies: ");
            }

            Console.Write("Enter Author ID: ");
            int authID;
            while (!int.TryParse(Console.ReadLine(), out authID))
            {
                Console.WriteLine("Invalid input. Please enter a valid author ID.");
                Console.Write("Enter Author ID: ");
            }

            Console.Write("Enter Category ID: ");
            int catID;
            while (!int.TryParse(Console.ReadLine(), out catID))
            {
                Console.WriteLine("Invalid input. Please enter a valid category ID.");
                Console.Write("Enter Category ID: ");
            }

            string query = "INSERT INTO Books VALUES (@ISBN, @Title, @Price, @Summary, @PYear, @Edition, @CopiesNo, @AuthorID, @CatID)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ISBN", ISBN);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Summary", summary);
                command.Parameters.AddWithValue("@PYear", pYear);
                command.Parameters.AddWithValue("@Edition", edition);
                command.Parameters.AddWithValue("@CopiesNo", copiesNo);
                command.Parameters.AddWithValue("@AuthorID", authID);
                command.Parameters.AddWithValue("@CatID", catID);
                command.ExecuteNonQuery();
            }
        }

        static void InsertNewMember(SqlConnection connection)
        {
            Console.Write("Adding a new member " + Environment.NewLine);
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter Street: ");
            string street = Console.ReadLine();

            int no_borrowbooks = 0;

            Console.Write("Enter Major: ");
            string major = Console.ReadLine();

            Console.Write("Enter University Name: ");
            string uniName = Console.ReadLine();

            string query = "INSERT INTO Members VALUES (@Email, @Password, @Fname, @Lname, @City, @Street, @NoBorrowBooks, @Major, @UniName)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", pass);
                command.Parameters.AddWithValue("@Fname", fname);
                command.Parameters.AddWithValue("@Lname", lname);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@NoBorrowBooks", no_borrowbooks);
                command.Parameters.AddWithValue("@Major", major);
                command.Parameters.AddWithValue("@UniName", uniName);
                command.ExecuteNonQuery();
            }
        }


        static void UpdateCopiesOfBook(SqlConnection connection)
        {
                Console.Write("You're now borrowing a book " + Environment.NewLine);

                Console.Write("Enter the title of the book you want to borrow: ");
                string bookTitle = Console.ReadLine();

                Console.Write("Enter your Member ID: ");
                int memberId;
                while (!int.TryParse(Console.ReadLine(), out memberId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid Member ID.");
                    Console.Write("Enter your Member ID: ");
                }

                string borrowDate = DateTime.Now.ToString("yyyy-MM-dd");
                string returnDate = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd");


                string getIsbn = "SELECT ISBN FROM Books WHERE Title = @Title";
                int isbn = 0;
                using (SqlCommand getIsbnCommand = new SqlCommand(getIsbn, connection))
                {
                    getIsbnCommand.Parameters.AddWithValue("@Title", bookTitle);
                    using (SqlDataReader reader = getIsbnCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isbn = (int)reader["ISBN"];
                        }
                    }
                }

                if (isbn == 0)
                {
                    Console.WriteLine("Book not found.");
                    return;
                }


                string updateCopiesQuery = "UPDATE Copies SET Availibility = 'False' WHERE BookID = @ISBN AND Availibility = 'True'";
                using (SqlCommand updateCopiesCommand = new SqlCommand(updateCopiesQuery, connection))
                {
                    updateCopiesCommand.Parameters.AddWithValue("@ISBN", isbn);
                    updateCopiesCommand.ExecuteNonQuery();
                }


                string updateBooksQuery = "UPDATE Books SET CopiesNo = CopiesNo - 1 WHERE ISBN = @ISBN AND CopiesNo > 0";
                using (SqlCommand updateBooksCommand = new SqlCommand(updateBooksQuery, connection))
                {
                    updateBooksCommand.Parameters.AddWithValue("@ISBN", isbn);
                    updateBooksCommand.ExecuteNonQuery();
                }

                string insertBorrowQuery = "INSERT INTO Borrow VALUES (@BorrowDate, @ReturnDate, @MemberID, @ISBN)";
                using (SqlCommand insertBorrowCommand = new SqlCommand(insertBorrowQuery, connection))
                {
                    insertBorrowCommand.Parameters.AddWithValue("@BorrowDate", borrowDate);
                    insertBorrowCommand.Parameters.AddWithValue("@ReturnDate", returnDate);
                    insertBorrowCommand.Parameters.AddWithValue("@MemberID", memberId);
                    insertBorrowCommand.Parameters.AddWithValue("@ISBN", isbn);
                    insertBorrowCommand.ExecuteNonQuery();
                }

                string updateMemberQuery = "UPDATE Members SET noBorrowBooks = noBorrowBooks + 1 WHERE ID = @MemberID";
                using (SqlCommand updateMemberCommand = new SqlCommand(updateMemberQuery, connection))
                {
                    updateMemberCommand.Parameters.AddWithValue("@MemberID", memberId);
                    updateMemberCommand.ExecuteNonQuery();
                }

                Console.WriteLine("Book borrowed successfully.");
        }

        static void UpdatePassword(SqlConnection connection)
        {
            Console.Write("Updating your password " + Environment.NewLine);
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter new password: ");
            string newPassword = Console.ReadLine();

            string query = "UPDATE Members SET Password = @Password WHERE Email = @Email";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@Email", email);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Password updated successfully.");
                }
                else
                {
                    Console.WriteLine("Email not found.");
                }
            }
        }

        static void DeleteBook(SqlConnection connection)
        {
            Console.Write("Deleting a book" + Environment.NewLine);
            Console.Write("Enter the title of the book to delete: ");
            string title = Console.ReadLine();

            string query = "DELETE FROM Books WHERE Title = @Title";

            string query2 = "DELETE FROM Copies WHERE Name = @Name";
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                command.Parameters.AddWithValue("@Name", title);

                int rowsAffected = command.ExecuteNonQuery();
            }

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Title", title);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"The book '{title}' has been successfully deleted.");
                }
                else
                {
                    Console.WriteLine($"No book found with the title '{title}'.");
                }
            }


        }

        static void SelectBookCopies(SqlConnection connection)
        {
            Console.WriteLine("Query to know how many copies of a book are available." + Environment.NewLine);
            Console.Write("Please enter the name of the book: ");
            string name = Console.ReadLine();

            string query = "SELECT CopiesNo FROM Books WHERE Title = @Title";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Title", name);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Title: {name}, Copies Available: {reader["CopiesNo"]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No book found with the given title.");
                    }
                }
            }
        }


        static void SelectBooksAndTheirCategories(SqlConnection connection)
        {
            Console.Write("Getting category name of a book" + Environment.NewLine);
            Console.Write("Please enter the name of the book: ");
            string name = Console.ReadLine();

            string query = "SELECT Categories.Name AS CategoryName, Books.Title AS BookTitle " +
                           "FROM Books " +
                           "INNER JOIN Categories ON Books.CatID = Categories.ID " +
                           "WHERE Books.Title = @Title";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Title", name);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Title: {reader["BookTitle"]}, Category: {reader["CategoryName"]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No book found with the given title.");
                    }
                }
            }
        }
    }
}
