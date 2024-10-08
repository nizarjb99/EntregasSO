#include <stdio.h>
#include <string.h>

#define MAX_LIBROS 100
#define MAX_LONGITUD 100

struct Libro{
	char titulo[MAX_LONGITUD];
	char autor[MAX_LONGITUD];
	int precio;
	int likes;
	
};

int main() {
	struct Libro biblioteca[MAX_LIBROS]
		
	strcpy(biblioteca[0].titulo, "La Cenicienta");
	strcpy(biblioteca[0].autor, "Sergi Siles");
	biblioteca[0].precio = 20;
	biblioteca[0].likes = 1500;
	
	print f("Libro: %s \n", biblioteca[0].titulo);
	print f("Autor: %s \n", biblioteca[0].autor);
	print f("Precio: %d \n", biblioteca[0].precio);
	print f("Likes: %d \n", biblioteca[0].likes);
	
	return 0;
}

int librosConMasDeNLikes(Libro listaLibros[], int totalLibros, int N, char *resultado) {
	int count = 0;
	char buffer[150];  
	resultado[0] = '\0';
	
	for(int i=0; i< totalLibros, i++) {
		if (listaLibros[i].likes > N)  {
		
			sprintf(buffer, "%s*%d", listaLibros[i].titulo, listaLibros[i].precio);
			
			if (count > 0) {
				strcat(resultado, "/");
			}
			
			strcat(resultado, buffer);
			
			count++;
		}
	}
	
	return count;
	
}
int main() {
	
	Libro libros[3] = {
		{"Dragon ball", "La sirenita", 23, 120},
	{"Doraemon el gato", "Pulgarcito", 42, 80},
		{"Blancanieves", "101 dalmatas", 15, 150}
	};
	
	char resultado[500]; 
	int N = 100;
	int totalLibros = 3;
	
	
	int librosFiltrados = librosConMasDeNLikes(libros, totalLibros, N, resultado);
	
	sprintf("Libros con mas de %d likes: %s\n", N, resultado);
	printf("Numero de libros encontrados: %d\n", librosFiltrados);
	
	return 0;
	
}

//EJERCICIOS LINUX

ls a*.txt | wc -1
	

	

