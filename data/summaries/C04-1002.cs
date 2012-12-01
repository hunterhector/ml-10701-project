Features By the “standard features” here we mean the feature set commonly used in (Uchimoto et al., 1999; Sekine et al., 2000; Kudo and Matsumoto, 2000; Kudo and Matsumoto, 2002).
C00-2109 C00-2110 E99-1026 W00-1303 W02-2016
In English as well as in Japanese, dependency analysis has been studied (e.g., (Lafferty et al., 1992; Collins, 1996; Eisner, 1996)).
C96-1058 P96-1025
Fujio and Matsumoto (1998) applied a modified version of Collins’ model (Collins, 1996) to Japanese dependency analysis.
P96-1025
The usage of these articles is the same as in (Uchimoto et al., 1999; Sekine et al., 2000; Kudo and Matsumoto, 2002).
C00-2109 C00-2110 E99-1026 W02-2016
These accuracies are slightly better than those in (Uchimoto et al., 1999), where combinations of features are manually selected.
E99-1026
and Matsumoto (2002) give more comprehensive comparison with the probabilistic models as used in (Uchimoto et al., 1999).
E99-1026
KM02 = Kudo and Matsumoto 2002, KM00 = Kudo and Matsumoto 2000, USI99 = Uchimoto et al.1999, and Seki00 = Sekine 2000.
C00-2109 C00-2110 E99-1026 W00-1303 W02-2016
One of the most related models is the cascaded chunking model by (Kudo and Matsumoto, 2002).
W02-2016
Uchimoto et al.(1999) used the backward beam search with ME.
E99-1026
Note that this use of local contexts is similar to the dynamic features in (Kudo and Matsumoto, 2002) 4. 5.3 Richer Features Inside a Bunsetsu With the standard features we will miss some case particles if the bunsetsu has two or more function words.
W02-2016
If the current modifier bunsetsu is a distinctive key bunsetsu (Kurohashi and Nagao, 1994, page 510), these features are triggered.
J94-4001
Theoretical comparison with (Kudo and Matsumoto, 2002) is described in Section 4.4.
W02-2016
Fortunately, solutions to this problem have already been given by Kudo and Matsumoto (2003).
P03-1004
Kudo and Matsumoto (2000) also used the same backward beam search together with SVMs rather than ME.
W00-1303
ID 0 1 2 3 4 Head 4 4 3 4 Figure 3: Sample Sentence Sekine (2000) observed that 98.7% of the head locations are covered by five candidates in a sentence.
C00-2109 C00-2110
Haruno et al.(1998) used decision trees to estimate the dependency probabilities.
P98-1083
Actually, this accuracy is almost the same as that of the cascaded chunking model without dynamic features (Kudo and Matsumoto, 2002).
W02-2016
Sekine (2000) also proposed a very fast parser that runs in linear time; however, accuracy is greatly sacrificed.
C00-2109 C00-2110
Kurohashi and Nagao (1994) proposed a method to detect conjunctive structures by calculating similarity scores between two sequences of bunsetsus.
J94-4001
Another interesting method that does not use dependency probabilities between each two bunsetsus is the cascaded chunking model by Kudo and Matsumoto (2002) based on the idea in (Abney, 1991; Ratnaparkhi, 1997).
W02-2016 W97-0301
Based on this observation, Sekine (2000) proposed an efficient analysis algorithm using deterministic finite state transducers.
C00-2109 C00-2110
According to (Sekine et al., 2000), the analyzing time followed a quadratic curve.
C00-2109 C00-2110
Sekine et al.(2000) used Maximum Entropy (ME) Modeling for dependency probabilities and proposed a backward beam search to find the best parse.
C00-2109 C00-2110
