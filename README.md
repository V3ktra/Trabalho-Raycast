# Trabalho-Raycast
Elaborar uma cena aplicando os conceitos de Raycast e iluminação desenvolvidos. No Git Hub disponibilizar os scripts utilizados e elaborar um read.me descrevendo de forma detalhada (incluir imagens) o desenvolvimento e os conceitos aplicados. Entregar o link e apresentar a cena em aula até o prazo de entrega

## Desenvolvimento
Colocamos um objeto "Cube" com a camera deixando a cena controlada em primeira pessoa, que quando utilizando o Input.GetKey para as teclas "a" e "d", a camera rotaciona para esquerda e direita <br>
Criamos uma prefab de uma "Sphere" que aparece de forma randomizada ao redor da plataforma (Vector3 randomSpawnPosition = ner Vector3(Random.Range());) com uma programação de "cooldown" (Time.deltaTime) para aparecer depois de certo tempo e um por fim um "Instantiade". <br>
Dentro do objeto cubo também foram adicionadas mais dois scripts, um para o RayCast, e outro para o HitBox. <br>
O código do RayCast consiste em criar uma fisica para o raycast onde quando apertado a tecla "space", se o objeto prefab estiver na linha do raycast, ele é destruido (Destroy(sphere)), se não o debug mostra "Target missed". <br>
Enquanto o código de HitBox indica que se a fisica do raycast colidir com um objeto com tag "Alvo", o debug mostra "Acertou" e destroi o objeto (Destroy(hit.transform.gameObject)). <br>
Também colocamos uma luz direcional para estilizar a cena.
