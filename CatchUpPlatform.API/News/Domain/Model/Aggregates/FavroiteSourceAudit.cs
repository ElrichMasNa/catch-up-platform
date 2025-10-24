using System.ComponentModel.DataAnnotations.Schema;

namespace CatchUpPlatform.API.News.Domain.Model.Aggregates;

public class FavroiteSourceAudit
{
    [Column(name:"CreatedAt")] public DateTimeOffset? CreatedDate { get; set; }
    [Column(name:"UpdatedBy")] public DateTimeOffset? UpdatedDate { get; set; }
}