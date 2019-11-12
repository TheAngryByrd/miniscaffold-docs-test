namespace DocsTool

module Uri =
    open System
    let simpleCombine (slug : string) (baseUri : Uri) =
        sprintf "%s/%s" (baseUri.AbsoluteUri.TrimEnd('/')) (slug.TrimStart('/'))
