using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net.Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Note Field API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/NoteFields">Note Field API documentation</a> for more information.
    public interface INoteFieldsClient
    {
        Task<IReadOnlyList<NoteField>> GetAll();
    }
}
