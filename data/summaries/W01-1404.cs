We will consider here only the so called RTN method, which is applied in a simplified form.3 3As opposed to (Nederhof, 2000), we assume here that all nonterminals are mutually recursive, and the grammar contains self-embedding.
J00-1003
2.1 hierarchical alignment The input to our algorithm is a corpus consisting of pairs of sentences related by an hierarchical alignment (Alshawi et al., 2000).
J00-1004
(Bangalore and Riccardi, 2001)), we also take into consideration a simple bigram model, trained on the strings comprising both source and target sentences and reorder operators, as explained in Section 4.
N01-1018
We have investigated a corpus of English/Japanese sentence pairs, related by hierarchical alignment (see also (Bangalore and Riccardi, 2001)).
N01-1018
This is the subject of existing studies, such as (Alshawi et al., 2000).
J00-1004
4 Finite-state approximation There are several methods to approximate context-free grammars by regular languages (Nederhof, 2000).
J00-1003
For certain lexicalized context-free models we even obtain higher time complexities when the size of the grammar is not to be considered as a parameter (Eisner and Satta, 1999).
P99-1059
We can reduce the generative power of contextfree transduction grammars by a syntactic restriction that corresponds to the bilexical context-free grammars (Eisner and Satta, 1999).
P99-1059
Bilexical transduction grammars are equivalent to the dependency transduction model from (Alshawi et al., 2000).
J00-1004
Some of these studies have concentrated on finite-state or extended finite-state machinery, such as (Vilar and others, 1999), others have chosen models closer to context-free grammars and context-free transduction, such as (Alshawi et al., 2000; Watanabe et al., 2000; Yamamoto and Matsumoto, 2000), and yet other studies cannot be comfortably assigned to either of these two frameworks, such as (Brown and others, 1990) and (Tillmann and Ney, 2000).
C00-2123 C00-2131 C00-2135 J00-1004 J90-2002
We have tried to obtain a rational transduction that approximates a 4It uses a trie to represent productions (similar to ELR parsing (Nederhof, 1994)), postponing generation of output for a production until all nonterminals and all input symbols from the right-hand side have been found.
P94-1017
P.F. Brown et al.1990. A statistical approach to machine translation.
J90-2002
