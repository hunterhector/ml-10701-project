The Japanese grammar utilizes much of the same codebase, but contains languagespecific grammar rules and additional features owing to the need for word-breaking in Japanese (Suzuki et al.2000; Kacmarcik et al.2000). These parsers are robust in that if the analysis grammar fails to find an appropriate parse, it outputs a best-guess “fitted” parse.
C00-1057 C00-2119
While much of this research effort has focused on acquisition of correspondences between individual lexical items or between unstructured strings of words, closer attention has begun to be paid to the learning of structured phrasal units: Yamamoto and Matsumoto (2000), for example, describe a method for automatically extracting correspondences between dependency relations in Japanese and English.
C00-2135
Suzuki. 2000.
C00-2119
The Spanish-English version of MSR-MT has been described in Richardson et al.2001a, Richardson et al 2001b, and the reader is referred to these papers for more information concerning algorithms employed during phrase alignment.
W01-1402
Yamamoto and Matsumoto (2000) explicitly assume that dependency relations between words will generally be preserved across languages.
C00-2135
Generation rules operate on a single tree only, are application-independent and are developed in a monolingual environment (see Aikawa et al.2001a, 2001b for further details).
W01-0808
Unlike the systems discussed in Yamamoto and Matsumoto (2000) and Imamura (2001a, 2001b), MSR-MT places the locus of translation knowledge acquisition at a greater level of abstraction than surface relations, pushing it into a semanticallymotivated layer called LOGICAL FORM (LF) (Heidorn 2000; Campbell & Suzuki 2002a, 2002b).
C00-2135
Introduction In the wake of the pioneering work of Nagao (1984), Brown et al.(1990) and Sato and Nagao (1990), Machine Translation (MT) research has increasingly focused on the issue of how to acquire translation knowledge from aligned parallel texts.
C90-3044 J90-2002
(See Menezes & Richardson 2001 for a detailed description of this process).
W01-1402 W01-1406
Kacmarcik. 2000.
C00-1057
The Mindnet is a general-purpose database of semantic information (Richardson et al.1998) that has been repurposed as the primary repository of translation information for MT applications.
P98-2180
The LF alignment algorithm first establishes tentative lexical correspondences between nodes in the source and target LFs on the basis of lexical matching over dictionary information and approximately 31,000 “word associations,” that is, lexical mappings extracted from the training corpora using statistical techniques based on mutual information (Moore 2001).
W01-1411
