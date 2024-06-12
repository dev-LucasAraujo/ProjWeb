﻿using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Endpoints.Requests
{
    public record MusicaRequest([Required] string nome, [Required] int ArtistaId, int anoLancamento);

}
