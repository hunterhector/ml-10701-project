In previous research on natural language processing, many methodologies for extracting various relations from corpora have been developed, such as the ?is-a??relation (Hearst 1992), ?part-of??relation (Berland and Charniak 1999), causal relation (Girju 2003), and entailment relation (Geffet and Dagan 2005).
C92-2082
Probably the best known such a general system is GATE (Cunninghametal.,1995;Cunninghametal.,2002), which contains some NE resources for Bulgarian and Russian (Humphreys et al., 2002; Popov et al., 2004) and allows to write shallow (regular) grammars in the JAPE subsystem (Cunningham et al., 2000).
P02-1022
Here, as in GATE (Cunningham, 2002), processing resource refers to programmatic or algorithmic resources, while language resource refers to data-only static resources such as lexicons or corpora.
P02-1022
Cunningham, et al.2002. GATE: A Framework and Graphical Development Environment for Robust NLP Tools and Applications.
P02-1022
12The numbers are so high ?probably due to the fact that the current corpus consists of encyclopedic material only??(Fahmi and Bouma, 2006, fn.4).
W06-2609
Patterns 4.1 Motivations Syntactic patterns provide clues for semantic relations (Hearst, 1992).
C92-2082
43 2 Related Work Definition extraction is an important NLP task, most frequently a subtask of terminology extraction (Pearson, 1996), the automatic creation of glossaries (Klavans and Muresan, 2000; Klavans and Muresan, 2001), question answering (Miliaraki and Androutsopoulos, 2004; Fahmi and Bouma, 2006), learning lexicalsemanticrelations(Malaiseetal., 2004; Storrer and Wellinghoff, 2006) and automatic construction of ontologies (Walter and Pinkal, 2006).
C04-1199 W06-0203 W06-2609
5.6 Postprocessing: Machine Learning and Keyword Identification Various approaches to the machine learning treatment of the task of classifying sentences or snippets as definitions or non-definitions can be found, e.g., in (Miliaraki and Androutsopoulos, 2004; Fahmi and Bouma, 2006) and references therein.
C04-1199 W06-2609
For example, (Fahmi and Bouma, 2006) report that a system trained on 2299 sentences, including 1366 definition sentences, may increase the accuracy of a definition extraction tool from 59% to around 90%.12 Another possible improvement may consist in, again, aiming at very high recall and then using an independent keyword detector to mark keywords (and key phrases) in text and classifying as genuine definitions those definitions, whose defined term has been marked as a keyword.
W06-2609
In fact, in turns out that virtually all successful attempts at definition extraction that we are aware of build on worked-out deep linguistic approaches (Klavans and 48 Muresan, 2000; Fahmi and Bouma, 2006; Walter and Pinkal, 2006), some of them combining syntactic and semantic information (Miliaraki and Androutsopoulos, 2004; Walter and Pinkal, 2006).
C04-1199 W06-0203 W06-2609
Tools for definition extraction are invariably languagespecific and involve shallow or deep processing, with most work done for English (Pearson, 1996; Klavans and Muresan, 2000; Klavans and Muresan, 2001) and other Germanic languages (Fahmi and Bouma, 2006; Storrer and Wellinghoff, 2006; Walter and Pinkal, 2006), as well as French (Malaise et al., 2004).
W06-0203 W06-2609
2Part of the representation has been replaced by ??...]?? 3Among the tools considered here were also CLaRK (Simov et al., 2001), ultimately rejected because it currently does not work in batch mode, and GATE / JAPE (Cunningham et al., 2002), not used here because we found GATE?s handling of previously XML-annotated texts rather cumbersome and illdocumented.
P02-1022
For example, Hearst(1992) uses the pattern ?NP such as List??to indicate that nouns in List are hyponyms of NP.
C92-2082
