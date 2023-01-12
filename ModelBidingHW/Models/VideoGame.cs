using System.ComponentModel.DataAnnotations;

namespace ModelBidingHW.Models;
/// <summary>
/// Object to hold a single video game
/// </summary>
public class VideoGame
{
    /// <summary>
    /// Title/name of the video game
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// MSRP/Current market price of the video game
    /// </summary>
    [Range(0, int.MaxValue)]
    public required double Price { get; set; }

    /// <summary>
    /// ESRB or PEGI age rating of the video game
    /// </summary>
    public required string AgeRating { get; set; }

    /// <summary>
    /// Publisher for the video game if NULL than is the same as Developer
    /// </summary>
    public string? Publisher { get; set; }  

    /// <summary>
    /// Developer of the video game
    /// </summary>
    public required string Developer { get; set; }
}

