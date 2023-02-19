﻿using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Collaborator;

public class ReadCollaboratorDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}
