ComportamentoAndar andar = new ComportamentoAndar();

ComportamentoNadar nadar = new ComportamentoNadar();

Homem homem = new Homem(andar);
homem.Locomocao();

Macaco macaco = new Macaco(andar);
macaco.Locomocao();

Sardinha sardinha = new Sardinha(nadar);
sardinha.Locomocao();

Console.ReadKey();