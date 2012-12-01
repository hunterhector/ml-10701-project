paper is organized as follows: We first summarize the results of our previous corpus study (Poesio and Vieira 1998) (Section 2) and then discuss the model of deftnite description processing that we adopted as a result of that work and the general architecture of the system (Section 3).
J98-2001
2. Preliminary Empirical Work As mentioned above, the architecture of our system is motivated by the results concerning definite description use in our corpus, discussed in Poesio and Vieira (1998).
J98-2001
of Bridging Descriptions Our work on bridging descriptions began with the development of a classification of bridging descriptions (Vieira and Teufel 1997) according to the kind of information needed to resolve them, rather than on the basis of the possible relations between descriptions and their anchors as is typical in the literature.
P97-1072
33 An implementation of a (simplified) version of Sidner's focus-tracking algorithms capable of being used by a system like ours was presented in Azzam, Humphreys, and Gaizauskas (1998).
M98-1007 P98-1011
fact, it is precisely because we are interested in identifying the types of commonsense reasoning actually used in language processing that we focused on definite descriptions rather than on other types of anaphoric expressions (such as pronouns and ellipsis) that can be processed much more effectively on the basis of syntactic information alone (Lappin and Leass 1994; Hardt 1997).
J94-4002 J97-4002
As already mentioned in Section 4.2, distinguishing between the two types of discourse-new descriptions identified by Hawkins, Prince, and others isn't easy even for humans (Fraurud 1990; Poesio and Vieira 1998); and indeed, our heuristics for recognizing discourse-new descriptions work better when evaluated together.
J98-2001
Finding better ways of segmenting the text is perhaps the area in which the most progress has been made since we started this project; robust methods for text segmentation are now available (Hearst 1997; Richmond, Smith, and Amitay 1997).
J97-1003 W97-0305
By contrast, in the evaluation of the MUC coreference task, where all types of referring expressions are considered, the resulting co-reference chains are evaluated, rather than just the indicated antecedent (Vilain et al.1995). Even our limited notion of coreference chain was, nevertheless, very helpful in the automatic evaluation, considerably reducing the number of cases to be checked manually.
M95-1005
Agreement among annotators was measured using the K statistic (Siegel and Castellan 1988; Carletta 1996).
J96-2004
The decision to develop a system that could be quantitatively evaluated on a large number of examples resulted in an important constraint: we could not make use of inference mechanisms such as those assumed by traditional computational theories of definite description resolution (e.g., Sidner 1979; Carter 1987; Alshawi 1990; Poesio 1993).
J90-3001
In the rest of this section, we describe the heuristics we developed for handling the first three of these classes: lexical bridges, bridges based on names, and bridges 558 Vieira and Poesio Processing Definite Descriptions to entities introduced by nonhead nouns in a compound nominal (Poesio, Vieira, and Teufel 1997).
P97-1072 W97-1301
This criticism is not new: In 1983, it was already recognized that an anaphoric full noun phrase may include some new and unshared information about a previously mentioned entity (Grosz, Joshi, and Weinstein 1983), and Carter (1987) weakened some of the restrictions proposed by Sidner in his system.
P83-1007
These problems have also been noted by the authors of systems participating in MUC-6 (Appelt 1995).
M95-1019
For the version of the system discussed and evaluated here, we implemented a preliminary algorithm for named entity recognition that we developed ourselves; a more recent version of the system (Ishikawa 1998) uses the named entity recognition software developed by HCRC for the MUC-7 competition (Mikheev, Moens, and Grover 1999).
E99-1001
recently, Bean and Riloff (1999) have proposed methods for automatically extracting from a corpus heads that correlate well with discourse novelty.
P99-1048
The possibility of using domain-specific, automatically acquired lexical information for this purpose is being explored: see, for example, Poesio, Schulte im Walde, and Brew (1998).
J98-2001
We generally assume in this paper that such differences are not significant, but a more formal significance test along the lines of that in Chinchor (1995) will eventually be necessary to verify this.
M95-1004
Some form of focusing seems to play a crucial role in restricting the range of antecedents (see also the discussion in Hitzeman and Poesio \[1998\]).
J98-2001 P98-1090
A second problem with Sidner's theory of local focus, as well as others such as Centering Theory (Grosz, Joshi, and Weinstein 1995), is the lack of a precise characterization of how to deal with complex sentences.
J95-2003
540 Vieira and Poesio Processing Definite Descriptions 2.1 The Corpus We used a subset of the Penn Treebank I corpus (Marcus, Santorini, and Marcinkiewicz 1993) from the ACL/DCI CD-ROM, containing newspaper articles from the Wall Street Journal.
J93-2004
32 This problem is also a central concern in the work by Bean and Riloff (1999).
P99-1048
A great number of definite descriptions with restrictive postmodifiers are unfamiliar in our corpus as well (Poesio and Vieira 1998); in fact, restrictive postmodification was found to be the single most frequent feature of first-mention descriptions.
J98-2001
In MUC-7, the best combined precision score, 93.39%, was achieved by the system from LTG in Edinburgh (Mikheev, Moens, and Grover 1999), which doesn't use such knowledge sources.
E99-1001
This so-called named entity recognition task has received considerable attention recently (Mani and MacMillan 1996; McDonald 1996; Paik et al.1996; Bikel et al.1997; Palmer and Day 1997; Wacholder and Ravin 1997; Mikheev, Moens, and Grover 1999) and was one of the tasks evaluated in the Sixth and Seventh Message Understanding Conferences.
A97-1028 A97-1029 A97-1030 E99-1001
We found that extended searches of this type, or searches for indirect meronymy relations, yielded extremely low recall and precision at a very high computational cost; both types of search were dropped at the beginning of the tests we ran to process the corpus consulting WordNet (Poesio, Vieira, and Teufel 1997).
P97-1072 W97-1301
Automatically recognizing the hierarchical structure of texts is an unresolved problem, as it involves reasoning about intentions; 14 better results have been achieved on the simpler task of "chunking" the text into sequences of segments, generally by means of lexical density measures (Hearst 1997; Richmond, Smith, and Amitay 1997).
J97-1003 W97-0305
The performance of the heuristics discussed in Section 4 was evaluated by comparing the results of the system with the human annotation of the corpus produced during the experiments discussed in Poesio and Vieira (1998).
J98-2001
The relation between bridging descriptions and their anchors may be arbitrarily complex (Clark 1977; Sidner 1979; Prince 1981; Strand 1996), and the same description may relate to different anchors in a text: this makes it difficult to decide what the intended anchor and the intended link are (Poesio and Vieira 1998).
J98-2001
Study of Definite Description Use In the experiments discussed in Poesio and Vieira (1998) we asked our subjects to classify all definite description uses in our two corpora.
J98-2001
26 An alternative method is to give fractional values to a classification depending on the number of agreements (Hatzivassiloglou and McKeown (1993).
P93-1023
This approach is challenged by the results of experiments we reported previously (Poesio and Vieira 1998), in which subjects were asked to classify the uses of definite descriptions in Wall Street Journal articles according to schemes derived from proposals by Hawkins (1978) and Prince (1981).
J98-2001
Even when our annotators agreed that a particular expression was a bridging description, different anchors would be available in the text for the interpretation of that bridging description• This makes the results of the system for this class very difficult to evaluate; furthermore, the results must be evaluated by hand• We first tested the heuristics individually on the training data (the same data used in a previous analysis of the performance of our system on bridging descriptions \[Vieira and Teufel 1997\]) by adding them to Version I of the system one at a time.
P97-1072
They make use of a knowledge base from which they extract conceptual links to feed an adaptation of the centering model (Grosz, Joshi, and Weinstein 1995).
J95-2003
We did not get a clear picture 34 As mentioned above, we have done some preliminary work on acquiring this information automatically (Poesio, Schulte im Walde, and Brew 1998; Ishikawa 1998).
J98-2001
Carletta et al.(1997) observe, however, that in other areas, such as medical research, much lower levels of K are considered acceptable (Landis and Koch 1977).
J97-1002
Kameyama (1997) analyzes in detail the coreference module of the SRI system that participated in MUC-6 (Appelt et al.1995). This system achieved one of the top scores for the coreference task: a recall of 59% and a precision of 72%.
M95-1019 W97-1307
Poesio and Vieira (1998), Hawkins's term "associative" was used for this class; but in fact, the definition we used for the class is closest to the sense of "bridging" used by Clark (1977).
J98-2001
Our analysis of these data, as well as of other corpora (Hitzeman and Poesio 1998), suggests that a local focusing mechanism as proposed in Grosz (1977), Sidner (1979), Grosz, Joshi, and Weinstein (1983, 1995), and Grosz and Sidner (1986) would improve the results obtained by our system.
J86-3001 J95-2003 J98-2001 P83-1007 P98-1090
32 Previous work on computational methods for definite description resolution can be divided in two camps: proposals that rely on commonsense reasoning (and are therefore either mainly theoretical or domain dependent), and systems that can be quantitatively evaluated, such as those competing on the coreference task in the Sixth and Seventh Message Understanding Conference (Sundheim 1995).
M95-1002
The set of potential antecedents of anaphoric expressions is also restricted by the fact that antecedents tend to have a limited "life span"--i.e., they only serve as antecedents for anaphoric expressions within pragmatically determined segments of the whole text (see, for example, Reichman \[1985\], Grosz and Sidner \[1986\] and Fox \[1987\]).
J86-3001
We developed a WordNet interface (Vieira and Teufel 1997) that reports a possible semantic link between two nouns when one of the following is true: • the nouns are in the same synset (i.e., they are synonyms of each other), as in suit~lawsuit; • the nouns are in a hyponymy/hypernymy relation with each other, as in dollar~currency; • there is a direct or indirect meronymy/holonymy (part of/has parts) relation between them, as in door~house; • the nouns are coordinate sisters, i.e. hyponyms of the same hypernym, such as home~house, which are hyponyms of housing, lodging.
P97-1072
The resolution process that transforms QLFs into resolved logical form representations of sentences is described in Alshawi (1990).
J90-3001
A broader view of bridging phenomena (not only bridging descriptions) is presented in Hahn, Strube, and Markert (1996).
C96-1084
The third main result was that we found very little agreement between our subjects on identifying briding descriptions: in our second experiment, the agreement on 5 Previous attempts to annotate anaphoric relations had resulted in very low agreement levels; for example, in the coreference annotation experiments for MUC-6 (Sundheim 1995), relations other than identity were dropped due to difficulties in annotating them.
M95-1002
(~) 2001 Association for Computational Linguistics Computational Linguistics Volume 26, Number 4 interpretation as well, for example, at the Sixth and Seventh Message Understanding Conferences (MUC-6 and MUC-7) (Sundheim 1995; Chinchor 1997), which also included evaluations of systems on the so-called coreference task, a subtask of which is the resolution of definite descriptions.
M95-1002
Because the agreement between our annotators in Poesio and Vieira (1998) was often only partial, in addition to precision and recall measures, we evaluated the system's performance by measuring its agreement with the annotators using the K statistic we used in Poesio and Vieira (1998) to measure agreement among annotators.
J98-2001
We plan to incorporate simpler focus-tracking mechanisms in future versions of the system, possibly along the lines of Azzam, Humphreys, and Gaizauskas (1998) or Tetreault (1999).
M98-1007 P98-1011 P99-1079
Our system, therefore, is based on a shallow-processing approach more radical even than that attempted by the first advocate of this approach, Carter (1987), or by the systems that participated in the MUC evaluations (Appelt et al.1995; Gaizaukas et al.1995; Humphreys et al.1988), since we made no attempt to fine-tune the system to maximize performance on a particular domain.
M95-1019
The system from Sheffield (Gaizauskas et al.1995), for instance, used a list of 2,600 names of organizations, 94 company designators (Co., Ltd, PLC, etc.), 160 titles (Dr., Mr., etc.), about 500 human names from the Oxford Advanced Learner's Dictionary, 2,268 place names (country, province, and city names), and other trigger words for locations, government institutions and organizations (Golf, Mountain, Agency, Ministry, Airline, etc.).
M95-1017
Revisions and extensions of Sidner's proposal related to these problems have been proposed in Suri and McCoy (1994), and include algorithms for updating focus in complex sentences containing adjunct clauses such as beforeand after-clauses.
J94-2006
14 See, however, Marcu (1999).
P99-1047
Restrictive modification is not as common in prenominal position as in posthead position, but it is often used, and was also found to correlate well with larger situation and unfamiliar uses of definite descriptions (Poesio and Vieira 1998).
J98-2001
In MUC-6, 15 different systems participated in the competition (Sundheim 1995).
M95-1002
549 Computational Linguistics Volume 26, Number 4 In general, it is not sufficient to look at the most recent antecedents only: this is because segments are organized hierarchically, and the antecedents introduced in a segment at a lower level are typically not accessible from a segment at a higher level (Fox 1987; Grosz 1977; Grosz and Sidner 1986; Reichman 1985), whereas the antecedents introduced in a prior segment at the same level may be.
J86-3001
In Poesio and Vieira (1998) we suggest that L/3bner's proposal (LSbner 1987) seems to account for the most data.
J98-2001
