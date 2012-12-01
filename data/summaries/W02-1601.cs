Figure 10 shows an example from Menezes and Richardson (2001), the logical form for the SpanishEnglish pair: (“En Información del hipervínculo, haga clic en la dirección del hipervínculo”, “Under Hyperlink Information, click the hyperlink address”).
W01-1406
Towards this aim, a flexible annotation structure called Structured String-Tree Correspondence (SSTC) was introduced in Boitet & Zaharin (1988) to record the string of terms, its associated representation structure and the mapping between the two, which is expressed by the sub-correspondences recorded as part of a SSTC.
C88-1013
3. SYNCHRONOUS SSTC STRUCTURE Much of theoretical linguistics can be formulated in a very natural manner as stating correspondences (translations) between layers of representation structures (Rambow & Satta, 1996), such as the relation between syntax and semantic.
P96-1016
Synchronous correspondence sn G41 st G41 (0-1,0-1) (0-4 0-1 2-3 34, 0-6 0-1 2-3 3-4 4-5) (0-1,0-1) (2-3,2-3) (2-3,2-3) beschenkte [v] (1-2/0-4) Er [n] (0-1/0-1) reichlich[adj] (3-4/3-4) Hans [n] (2-3/2-3) 0 Er 1 beschenkte 2 Hans 3 reichlich 4 give[v] (1-2/0-6) He [n] (0-1/0-1) John [n] (2-3/2-3) present [n] (5-6/3-6) an[det] (3-4/3-4) expansive[adj] (4-5/4-5) 0 He 1 gave 2 John 3 an 4 expansive 5 5 present 6 (3-4,4-5) (0-4,0-6) (3-4,4-5) 2000), (Meyers et al., 2000), (Matsumoto et al., 1993) and (kaji et al., 1992).
C00-1078 P93-1004
For example, synchronous Tree Adjoining Grammar (S-TAG) can be used to relate TAGs for two different languages, for example, for the purpose of immediate structural translation in machine translation (Abeillé et al.,1990), (Harbusch & Poller,1996), or for relating a syntactic TAG and semantic one for the same language (Shieber & Schabes,1990).
C90-3045
For more details on the proprieties of SSTC, see Boitet & Zaharin (1988).
C88-1013
S-TAG is a variant of Tree Adjoining Grammar (TAG) introduced by (Shieber & Schabes,1990) to characterize correspondences between tree adjoining languages.
C90-3045
In this paper, a flexible annotation schema called Structured String-Tree Correspondence (SSTC) (Boitet & Zaharin, 1988) will be introduced to capture a natural language text, its corresponding abstract linguistic representation and the mapping (correspondence) between these two.
C88-1013
Much of theoretical linguistics can be formulated in a very natural manner as stating correspondences (translations) between layers of representation structures (Rambow & Satta, 1996).
P96-1016
G30G52G55G48 G53G55G48G56G48G51G57G44G57G4CG52G51G56 G52G49 G30G37G37 G46G44G51 G45G48 G49G52G58G51G47 G4CG51 G0BG30G48G4FGB6GFEG58G4EG0F G14G1CG1CG1AG0C G44G51G47 G0BG30G4CG4FG4CGFCG48G59G4CGFCG0F G15G13G13G14G0CG11 2.1 The SSTC Annotation Structure The SSTC is a general structure that can associate an arbitrary tree structure to string in a language as desired by the annotator to be the interpretation structure of the string, and more importantly is the facility to specify the correspondence between the string and the associated tree which can be nonprojective (Boitet & Zaharin, 1988).
C88-1013
For example, such schema can serve as a mean to represent translation examples, or find structural correspondences for the purpose of transfer grammar learning (Menezes & Richardson, 2001), (Aramaki et al., 2001), (Watanabe et al., 2000), (Meyers et al., 2000), (Matsumoto et al., 1993), (kaji et al., 1992), and example-base machine translation EBMT 3 (Sato & Nagao, 1990), (Sato, 1991), (Richardson et al., 2001), (Al-Adhaileh & Tang, 1999).
C00-1078 C00-2131 C90-3044 P93-1004 W01-1406
For instance, when building translation units in EBMT approaches (Richardson et al., 2001), (Aramaki, 2001), (AlAdhaileh &Tang, 1999), (Sato & Nagao, 1990), (Sato, 1991), (Sadler & Vendelmans, 1990), etc., where S-SSTC can be used to represent the entries of the BKB or when S-SSTC used as an annotation schema to find the translation correspondences (lexical and structural correspondences) for transferrules’ extraction from parallel parsed corpus (Menezes & Richardson, 2001), (Watanabe et al., Tree String Tree String Figure 9: Partial subtree/s correspondence: the German sentence “Er beschenkte Hans reichlich” and its corresponding English sentence “He gave John an expensive present”; i.e. the use of (-) operation to calculate the Y:STREE interval.
C90-3044 C90-3101 W01-1406
Note that the grammar alignment rules used in (Menezes & Richardson, 2001) can be reformulated using these constraints to construct the transfer mappings from a synchronous source-target example.
W01-1406
A substring in the sentence that corresponds to a node in the representation tree is denoted by assigning the interval of the substring to SNODE of 2 These definitions are based on the discussion in (Tang, 1994) and Boitet & Zaharin (1988).
C88-1013
