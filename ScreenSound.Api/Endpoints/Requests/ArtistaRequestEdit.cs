﻿namespace ScreenSound.API.Endpoints.Requests
{
    public record ArtistaRequestEdit
    (int Id, string nome, string bio) : ArtistaRequest(nome, bio);
}
