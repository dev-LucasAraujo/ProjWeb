namespace ScreenSound.API.Endpoints.Requests
{
    public record MusicaRequestEdit
    (int Id, string nome, int ArtistaId, int anoLancamento) : MusicaRequest(nome, ArtistaId, anoLancamento);
}
