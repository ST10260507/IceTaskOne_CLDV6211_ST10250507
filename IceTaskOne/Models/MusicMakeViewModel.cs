using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace IceTaskOne.Models;

public class MusicMakeViewModel
{
    public List<Music>? MusicItems { get; set; }
    public SelectList? Make { get; set; }
    public string? MusicMake { get; set; }
    public string? SearchString { get; set; }
}