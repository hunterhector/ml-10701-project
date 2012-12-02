See Bangalore et al.(2002) and Barzilay and Lee (2002) for other uses of such data.
C02-1134 W02-1022
This could, for example, aid machine-translation evaluation, where it has become common to evaluate systems by comparing their output against a bank of several reference translations for the same sentences (Papineni et al., 2002).
P02-1040
Jacquemin (1999) and Barzilay and McKeown (2001) identify phraselevel paraphrases, while Lin and Pantel (2001) and Shinyama et al.(2002) acquire structural paraphrases encoded as templates.
P01-1008 P99-1044
However, in studies of paraphrases across several domains (Iordanskaja et al., 1991; Robin, 1994; McKeown et al., 1994), this was generally not the case.
A94-1002
In addition to the advantages mentioned above, comparable corpora can be easily obtained for many domains, whereas previous approaches to paraphrase acquisition (and the related problem of phrasebased machine translation (Wang, 1998; Och et al., 1999; Vogel and Ney, 2000)) required parallel corpora.
C00-2172 W99-0604
Applications include summarization (Knight and Marcu, 2000) and rewriting (Chandrasekar and Bangalore, 1997): both could employ such a mechanism to produce candidate sentence paraphrases that other system components would filter for length, sophistication level, and so forth.1 Not surprisingly, therefore, paraphrasing has been a focus of generation research for quite some 1Another interesting application, somewhat tangential to generation, would be to expand existing corpora by providing time (McKeown, 1979; Meteer and Shaked, 1988; Dras, 1999).
C88-2088 P79-1016
Learning synonyms via distributional similarity has been well-studied (Pereira et al., 1993; Grefenstette, 1994; Lin, 1998).
P93-1024 P98-2127
We point out that one such approach, recently proposed by Pang et al.(2003), also represents paraphrases by lattices, similarly to our method, although their lattices are derived using parse information.
N03-1024
McKeown. 1979.
P79-1016
Lattices have proven advantageous in a number of NLP contexts (Mangu et al., 2000; Bangalore et al., 2002; Barzilay and Lee, 2002; Pang et al., 2003), but were usually produced from (multi-)parallel data, which may not be readily available for many applications.
C02-1134 N03-1024 W02-1022
3Scoring function: aligning two identical words scores 1; inserting a word scores -0.01, and aligning two different words scores -0.5 (parameter values taken from Barzilay and Lee (2002)).
W02-1022
