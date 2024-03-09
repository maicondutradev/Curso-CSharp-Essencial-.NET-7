Professor professor1 = new Professor("Maicon", "Frontend");
Professor professor2 = new Professor("Mirela", "Backend");
Professor professor3 = new Professor("Gabriel", "Infraestrutura");
Professor professor4 = new Professor("Matheus", "Economia");
Professor professor5 = new Professor("Naruto", "Gestão empresarial");
Professor professor6 = new Professor("Yuta", "Gestão ambiental");

Departamento departamento1 = new Departamento("Computação");
departamento1.IncluirProfessor(professor1);
departamento1.IncluirProfessor(professor2);
departamento1.IncluirProfessor(professor3);

departamento1.ListaProfessores();


Departamento departamento2 = new Departamento("Negócios");
departamento2.IncluirProfessor(professor4);
departamento2.IncluirProfessor(professor5);
departamento2.IncluirProfessor(professor6);

departamento2.ListaProfessores();

Console.ReadKey();