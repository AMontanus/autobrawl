﻿namespace Autobrawl.Model.Objects;
public class Card
{
    /// <summary>
    /// [1][Aspect][Level][Order]
    /// </summary>
    [Required]
    public int ID { get; set; } 
    [Required]
    public string Name { get; set; }

    public string Text { get; set; }

    [Required]
    public int BaseAttack { get; set; }
    [Required]
    public int BaseHealth { get; set; }
    [Required]
    public Level Level { get; set; }

    [Required]
    public Aspect Aspect { get; set; }

    public Keywords Keywords { get; set; }
}
