First, we use a method based on CLIR to align Japanese and English articles (Collier et al., 1998; Matsumoto and Tanaka, 2002) and then a method based on DP matching to align Japanese and English sentences (Gale and Church, 1993; Utsuro et al., 1994) in these articles.
C94-2175 J93-1004 P98-1041
Collier et al.(1998) compared the use of machine translation (MT) with the use of bilingual dictionary term lookup (DTL) for news article alignment in Japanese and English.
P98-1041
4http://trec.nist.gov/ 5We split the Japanese articles into sentences by using simple heuristics and split the English articles into sentences by using MXTERMINATOR (Reynar and Ratnaparkhi, 1997).
A97-1004
The recall, R, and precision, P, of the program against this corpus were R = 0:982 and P = 0:986, respectively, where 6SIM(Ji;Ei) is different from the similarity function used in Utsuro et al.(1994). We use SIM because it performed well in a preliminary experiment.
C94-2175
We use Brill’s tagger (Brill, 1992) to POS-tag the English sentences, extract content words, and use WordNet’s library7 to obtain lemmas of the words, which consists of Ei.
A92-1021
We first aligned the articles using a method based on CLIR (Collier et al., 1998; Matsumoto and Tanaka, 2002) and then aligned the sentences in these articles by using a method based on dynamic programming (DP) matching (Gale and Church, 1993; Utsuro et al., 1994).
C94-2175 J93-1004 P98-1041
alignment The sentences5 in the aligned Japanese and English articles are aligned by a method based on DP matching (Gale and Church, 1993; Utsuro et al., 1994).
C94-2175 J93-1004
Readers are referred to Utsuro et al.(1994) for a concise description of the algorithm.
C94-2175
