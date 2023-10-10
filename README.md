
# Calendar API
## API .NET, demo avec WinForms, tests unitaire avec NUnit

Application de démo disponible depuis la release dans la branche dev

L'API est contenu dans une bibliothèque de classes appelé CalendrierApi.
Elle renvoie une liste de IEnumerable en fonction de la date donnée qu'on lui fournit (soit au format DateTime, soit au format (int year, int month)) avec des méthodes surchargées, en appelant la méthode GetDaysInMonth() dans la classe statique Calendar.

