We have also implemented the traditional NE-retraining approach proposed by [Kubala et al.1998] [Miller et al.2000] [Palmer et al.2000] and the re-trained NE model leads to 3 In fact, positive effects are observed in some cases.
A00-1044
Bikel, D.M. et al.1997. Nymble: a HighPerformance Learning Name-finder.
A97-1029
[Bikel et al.1997], [Krupka & Hausman 1998]) utilize case-related features.
A97-1029 M98-1015
Typically QA is supported by Natural Language Processing (NLP) and IE [Chinchor & Marsh 1998] [Hovy et al.2001] [Srihari & Li 2000].
A00-1023 M98-1027
Examples of using NLP and IE in Question Answering include shallow parsing [Kupiec 1993] [Srihari & Li 2000], deep parsing [Li et al.2002] [Litkowski 1999] [Voorhees 1999], and IE [Abney et al.2000] [Srihari & Li 2000].
A00-1023 A00-1041 W02-1905
Answering Based on IE We use a QA system supported by increasingly sophisticated levels of IE [Srihari & Li 2000] [Li et al.2002]. Figure 1 presents the underlying IE engine InfoXtract [Srihari et al.2003] that forms the basis for the QA system.
A00-1023 W02-1905 W03-0808
Srihari. 2003.
W03-0808
For a system based on language models, a feature exclusion approach is used to re-train the models, excluding features related to the case information [Kubala et al.1998] [Miller et al.2000] [Palmer et al.2000]. In particular, the DARPA HUB-4 program evaluates NE systems on speech recognizer output in SNOR (Standard Normalized Orthographic Representation) that is case insensitive and has no punctuations [Chincor et al.1998]. Research on case insensitive text has so far been restricted to NE and the feature exclusion approach [Chieu & Ng 2002] [Kubala et al.1998] [Palmer et al.2000] [Robinson et al.1999]. When we examine a system beyond the shallow processing of NE, the traditional feature exclusion approach may not be feasible.
A00-1044 P02-1061
