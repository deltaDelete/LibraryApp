using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

[Table("clients")]
public class Client {
    [Key]
    [Column("client_id")]
    public int ClientId { get; set; }
    [Column("first_name")]
    public string FirstName { get; set; }
    [Column("last_name")]
    public string LastName { get; set; }
    [Column("gender_id")] 
    public int GenderId { get; set; }
    public Gender? Gender { get; set; }
}