Hearst y Harvard University University of California, Berkeley The P k evaluation metric, initially proposed by Beeferman, Berger, and Lafferty (1997), is becoming the standard measure for assessing text segmentation algorithms.
W97-0304
Researchers have explored the use of this kind of document segmentation to improve automated summarization (Salton et al.1994; Barzilay and Elhadad 1997; Kan, Klavans, and McKeown 1998; Mittal et al.1999; Boguraev and Neff 2000) and automated genre detection (Karlgren 1996).
W97-0703 W98-1123
More recently, a great deal of interest has arisen in using automatic segmentation for the detection of topic and story boundaries in news feeds (Mani et al.1997; Merlino, Morey, and Maybury 1997; Ponte and Croft 1997; Hauptmann and Witbrock 1998; Allan et al.1998; Beeferman, Berger, and Lafferty 1997, 1999).
W97-0304
Other techniques use clustering and/or similarity matrices based on word co-occurrences (Reynar 1994; Yaari 1997; Choi 2000), and still others use machine learning techniques to detect cue words, or hand-selected cue words to detect segment boundaries (Passonneau and Litman 1993; Beeferman, Berger, and Lafferty 1997; Manning 1998).
A00-2004 P93-1020 P94-1050 W97-0304
2. Analysis of the P k Error Metric The P k metric is fast becoming the standard among researchers working in text segmentation (Allan et al.1998; Dharanipragada et al.1999; Eichmann et al.1999; van Mulbregt et al.1999; Choi 2000).
A00-2004
For this reason, some researchers prefer not to measure the segmentation algorithm directly, but consider its impact on the end application (Manning 1998; Kan, Klavans, and McKeown 1998).
W98-1123
Text segmentation issues are also important for passage retrieval, a subproblem of information retrieval (Hearst and Plaunt 1993; Salton, Allan, and Buckley 1993; Callan 1994; Kaszkiel and Zobel 1997).
J97-1003 P94-1002
P k Evaluation Metric Beeferman, Berger, and Lafferty (1997) introduce a new evaluation metric that attempts to resolve the problems with precision and recall, including assigning partial credit to near misses.
W97-0304
Sometimes segmentation is done at the clause level, for the purposes of detecting nuances of dialogue structure or for more sophisticated discourse-processing purposes (Morris and Hirst 1991; Passonneau and Litman 1993; Litman and Passonneau 1995; Hirschberg and Nakatani 1996; Marcu 2000).
J91-1002 P93-1020 P95-1015 P96-1038
Some evaluations circumvent this difficulty by detecting boundaries in sets of concatenated documents, where there can be no disagreements about the fact of the matter (Reynar 1994; Choi 2000); others have several human judges make ratings to produce a “gold standard.” The second difficulty with evaluating these algorithms is that for different applications of text segmentation, different kinds of errors become important.
A00-2004 P94-1050
E-mail: hearst@sims.berkeley.edu c© 2002 Association for Computational Linguistics Computational Linguistics Volume 28, Number 1 of it, for subtopic segmentation (Nomoto and Nitta 1994; Hasnah 1996; Richmond, Smith, and Amitay 1997; Heinonen 1998; Boguraev and Neff 2000).
C94-2187 P98-2244 W97-0305
Its contents can be described as consisting of the following subtopic discussions (numbers indicate paragraphs): 1–3 Introduction: The search for life in space 4–5 The moon’s chemical composition 6–8 How early earth-moon proximity shaped the moon 9–12 How the moon helped life evolve on earth 13 Improbability of the earth-moon system 14–16 Binary/trinary star systems make life unlikely 17–18 The low probability of nonbinary/trinary systems 19–20 Properties of earth’s sun that facilitate life 21 Summary The TextTiling algorithm (Hearst 1993, 1994, 1997) attempts to recognize these subtopic changes by making use of patterns of lexical co-occurrence and distribution; subtopic boundaries are assumed to occur at the point in the documents at which large shifts in vocabulary occur.
J97-1003 P94-1002
An example, drawn from Hearst (1997), is a 21paragraph science news article, called “Stargazers,” whose main topic is the existence of life on earth and other planets.
J97-1003
