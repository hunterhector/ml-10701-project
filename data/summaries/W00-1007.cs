Then I present an adaptation to Danish of Eckert and Strube's algorithm for resolving anaphora referring to individual NPs and abstract objects in English dialogues (Eckert and Strube, 1999b; Eckert and Strube, 1999a).
E99-1006 J99-3001
Eckert and Strube (1999a; 1999b), henceforth ES99, describe an algorithm for resolving anaphors referring to individual NPs and abstract objects in English dialogues.
E99-1006 J99-3001
Predicates that are preferentially associated with individual objects are the following (Eckert and Strube, 1999b)\[p.
E99-1006 J99-3001
One of the most popular approaches to anaphora resolution is centering (Grosz et al., 1995), henceforth GJW95, which accounts for the relation between the saliency of entities in discourse and the use of referring expressions, incorporating syntax, semantics and pragmatics.
J95-2003
I also beheve that the contexts of abstract anaphors should be studied in more dialogues, and that more attention should be given to the connection between discourse deictics and the relations that \]in~ pieces of discourse to each other (Webber, 1991; Fraurud, 1992; Asher, 1993; Kehler, 1997).
J97-3006
Byron and Stent (1998), in particular, test centering on multi-party dialogues.
P98-2241
The results obtained are better than those reposed in (Eckert and Strube, 1999a), but I have used more background information than ES99 and extended the scope of resolution for individual anaphors (without this extension the precision of the individual resolution algorithm was of 64.5).
E99-1006 J99-3001
ES99 define the following *I predicates (Eckert and Strube, 1999b)\[p.
E99-1006 J99-3001
Given that Uttx and utty refer to Un or Un-1, the follow57 Table 1: Transition States OR no Cb(U.-1) CONTINUE RETAIN SHIFT ing ranking constraints on the S-list entities are valid (Strube, 1998)\[p.1253\]: s 1.
P98-2204
I have defined dialogue units syntactically following (Eckert and Strube, 1999a).
E99-1006 J99-3001
Centering fits into Grosz and Sidner's model of discourse structure (Grosz and Sidner, 1986).
J86-3001
They conclude that centering seems to be a valid theory also in this case, but it must be extended to ac2In (Strube and Hah~ 1996) a functional-based prominence ranking has been proposed.
P96-1036
Strube and Hahn (Strube, 1998; Strube and H~.hn, 1999) in particular, calculate prominence considering the information structure of the utterances (functional centering).
J99-3001 P98-2204
section 2 I shortly present the original centering framework and functional centering as described in (Strube, 1998), $98.
P98-2204
The individual anaphors are then resolved by the functional centering algorithm described in (Strube, 1998), while abstract anaphors are resolved with a different algorithm.
P98-2204
In (Eckert and Strube, 1999a) these tasks have been accomplished by two annotators.
E99-1006 J99-3001
The anaphora resolution algorithm for third person singular neuter personal pronouns is the following (Eckert and Strube, 1999a): case PRO is I-incompatible if resolveDiscourseDeictic(P RO ) then classify as discourse deictic else classify as vague pronoun; case PRO is A-incompatible if resolveIndividual (PRO ) then classify as individual pronoun else classify as vague pronoun; case PRO is ambiguous if resolveIndividual(PRO ) then classify as individual pronoun else if resolveDiscourseDeictic(PRO) then classify as discourse deictic else classify as vague pronoun; The same algorithm is used for demonstratives, with the exception that the last two if constructions in the algorithm for pronouns are reversed reflecting the preference for demonstratives to be discourse deictics (Webber, 1991).
E99-1006 J99-3001
