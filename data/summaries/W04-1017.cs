Summarization Model Many summarization systems (e.g., (Teufel and Moens, 1997; McKeown et al., 1999; Lin and Hovy, 2000)) include two levels of analysis: the sentence level, where every textual unit is scored according to c1 c2 c3 c4 c5 t1 1 1 0 1 1 t2 1 0 0 1 0 t3 0 1 0 0 1 t4 1 0 1 1 1 Table 1: Matrix for Summarization Model the concepts or features it covers, and the text level, where, before being added to the final output, textual units are compared to each other on the basis of those features.
C00-1072 W97-0710
There exist approaches that deal mainly with lexical features, like tf*idf weighing of words in the input text(s), words used in the titles and section headings (Luhn, 1958; Edmundson, 1968), or the presence or absence of certain cue phrases like significant, important, and in conclusion (Kupiec et al., 1995; Teufel and Moens, 1997).
W97-0710
We explore properties of this model in more detail in (Filatova and Hatzivassiloglou, 2004).
C04-1057
The method, ROUGE (Lin and Hovy, 2003), is based on n-gram overlap between the system-produced and ideal summaries.
N03-1020
Concepts do not have to be directly observable as text snippets—they can represent abstract properties that particular text units may or may not satisfy, for example, status as a first sentence in a paragraph or generally position in the source text (Baxendale, 1958; Lin and Hovy, 1997).
A97-1042
Some summarization systems assume that the importance of a sentence is derivable from a rhetorical representation of the source text (Marcu, 1997).
W97-0713
Other systems exploit the co-occurrence of particular concepts (Barzilay and Elhadad, 1997; Lin and Hovy, 2000) or syntactic constraints between concepts (McKeown et al., 1999).
C00-1072 W97-0703
