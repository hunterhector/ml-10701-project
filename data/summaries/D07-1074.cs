Nonetheless, there are a non-negligible number of cases in which the one sense per discourse assumption (Gale et al., 1992) does not hold.
H92-1045
Ravin and Kazi (1999) further refined the method of solving coreference through measuring context similarity and integrated it into Nominator (Wacholder et al., 1997), which was one of the first successful systems for named entity recognition and co-reference resolution.
A97-1030
Michener. Bagga and Baldwin (1998) tackled the problem of cross-document coreference by comparing, for any pair of entities in two documents, the word vectors built from all the sentences containing mentions of the targeted entities.
P98-1012
When it was introduced, in the 6th Message Understanding Conference (Grishman and Sundheim, 1996), the named entity recognition task comprised three entity identification and labeling subtasks: ENAMEX (proper names and acronyms designating persons, locations, and organizations), TIMEX (absolute temporal terms) and NUMEX (numeric expressions, monetary expressions, and percentages).
C96-1079
As Wacholder et al.(1997) noted, it is fairly common for one of the mentions of an entity in a document to be a long, typical surface form of that entity (e.g., “George W.
A97-1030
In a second stage, a hybrid named-entity recognizer based on capitalization rules, Web statistics, and statistics extracted from the CoNLL 2003 shared task data (Tjong Kim Sang and De Meulder, 2003) identifies the boundaries of the entity mentions in the text and assigns each set of mentions sharing the same surface form a probability distribution over four labels: Person, Location, Organization, and Miscellaneous.1 The named entity recognition component resolves the structural ambiguity with regard to conjunctions (e.g., “Barnes and Noble”, “Lewis and Clark”), possessives (e.g., “Alice's Adventures in Wonderland”, “Britain's Tony Blair”), and prepositional attachment (e.g., “Whitney Museum of American Art”, “Whitney Museum in New York”) by using the surface form information extracted from Wikipedia, when available, with back-off to co-occurrence counts on the Web, in a similar way to Lapata and Keller (2004).
N04-1016 W03-0419
The entity identification and in-document coreference components resemble the Nominator system (Wacholder et al., 1997).
A97-1030
The most similar work to date was published by Bunescu and Paca (2006).
E06-1002
Lexicosyntactic patterns have been employed successfully in the past (e.g., Hearst, 1992; Roark and Charniak, 1998; Cederberg and Widdows, 2003), and this type of tag extraction is still a promising direction for the future.
C92-2082 P98-2182 W03-0415
Mann and Yarowsky (2003) addressed the task of clustering the Web search results for a set of ambiguous personal names by employing a rich feature space of biographic facts obtained via bootstrapped extraction patterns.
W03-0405
Since 1995, other similar named entity recognition tasks have been defined, among which CoNLL (e.g., Tjong Kim Sang and De Meulder, 2003) and ACE (Doddington et al., 2004).
W03-0419
