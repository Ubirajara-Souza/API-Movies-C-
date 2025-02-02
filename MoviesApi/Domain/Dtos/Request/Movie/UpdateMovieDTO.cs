﻿using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Domain.Dtos.Request.Movie
{
    public class UpdateMovieDTO
    {
        [Required(ErrorMessage = "O campo Título é obrigatório")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O campo Duração é obrigatório")]
        [Range(30, 360, ErrorMessage = "Duração do filme deve ter no mínimo 30 min e no máximo 360 min")]
        public int Duration { get; set; }
    }
}
