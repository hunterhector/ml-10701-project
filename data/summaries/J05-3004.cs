3. The Alternative: Corpus-Based Knowledge Extraction There have been a considerable number of efforts to extract lexical relations from corpora in order to build new knowledge sources and enrich existing ones without time9 Even without extensive mining, this risk can be high: Vieira and Poesio (2000) report a high number of false positives for one of their data sets, although they use only WordNet-encoded links.
J00-4003
In fact, it has been argued by several researchers that an anaphora resolution algorithm should proceed to antecedent selection only if a given definite NP is anaphoric (Ng and Cardie 2002a; Ng 2004; Uryupina 2003; Vieira and Poesio 2000, among others), therefore advocating a twostage process which we also follow in this article.
C02-1139 J00-4003 P02-1014 P03-2012 P04-1020
In a previous experiment we used mutual information to normalize Web scores (Markert, Nissim, and Modjeska 2003).
W03-1023
Specifically, the WordNet-based algorithms could be improved by exploiting information encoded in WordNet beyond explicitly encoded links (glosses could be mined, too, for example; see also Harabagiu, Bunescu, and Maiorano [2001]).
N01-1008
Hahn, Strube, and Markert (1996) report experiments on 109 bridging cases from German information technology reports, using a hand-crafted, domain-specific knowledge base of 449 concepts and 334 relations.
C96-1084
As an example, the pattern NP 1 and other NP 2 usually expresses a hyponymy/similarity relation between the hyponym NP 1 and its hypernym NP 2 (Hearst 1992), and it can therefore be postulated that two noun phrases that occur in such a pattern in a corpus should be linked in an ontology via a hyponymy link.
C92-2082
They use, for example, a relatively coarse-grained notion of semantic compatibility between a few high-level concepts in WordNet (Soon, Ng, and Lim 2001), or more detailed hyponymy and synonymy links between anaphor and antecedent head nouns (Vieira and Poesio 6 A two-stage process in which the first stage identifies anaphoricity of the NP and the second the antecedent for anaphoric NPs (Uryupina 2003; Ng 2004) can alleviate this problem.
J01-4004 P03-2012 P04-1020
Vieira and Poesio (2000) report results on anaphoric definite NPs in the WSJ that stand in a synonymy or hyponymy relation to their antecedents (as in Example (1)).
J00-4003
For a computational treatment of other-NPs with structural antecedents, see Bierner (2001).
P01-1009
On the other hand, considering only the most frequent sense for anaphor and antecedent (as is done in Soon, Ng, and Lim [2001]) might lead to wrong antecedent assignment if a minority sense is intended in the text.
J01-4004
semantic knowledge used might also not necessarily improve on string matching: Soon, Ng, and Lim (2001) final, automatically derived decision tree does not incorporate their semantic-compatibility feature and instead relies heavily on string matching and aliasing, thereby leaving open how much information in a lexical hierarchy can improve over string matching.
J01-4004
A number of researchers (Hearst 1992; Berland and Charniak 1999, among others) have suggested that knowledge bases be enhanced via (semi)automatic knowledge extraction from corpora, and such enhanced knowledge bases have also been used for anaphora resolution, specifically for bridging (Poesio et al.2002; Meyer and Dale 2002).
C92-2082 P99-1008
Although recent work on automatic anaphoricity determination has shown promising results (Ng 2004; Uryupina 2003), our algorithms will perform worse when building on non-manually determined anaphors.
P03-2012 P04-1020
37 Curran and Clark’s (2003) tagger was not available to us during the first case study.
W03-0424
370 Markert and Nissim Knowledge Sources for Anaphora Resolution 2000; Harabagiu, Bunescu, and Maiorano 2001; Ng and Cardie 2002b, among others).
C02-1139 N01-1008 P02-1014
In this experiment, named entities were resolved using Curran and Clark’s (2003) NE tagger rather than GATE.
W03-0424
Vieira and Poesio (2000) report that 62.0% of meronymy relations (see Example (2)) needed for bridging resolution in their corpus were not encoded in WordNet.
J00-4003
Thus, Hearst (1992) raises the issue of whether underspecified, contextor point-of-view-dependent hyponymy relations (like the context-dependent link between costs and repercussions in Example (3)) should be included in a fixed ontology, in addition to universally true hyponymy relations.
C92-2082
Others involve such, including,and especially (Hearst 1992) or appositions and coordination.
C92-2082
Knowledge might be encoded in many different ways in a lexical hierarchy, and this can pose a problem for anaphora resolution (Humphreys et al.1997; Poesio, Vieira, and Teufel 1997).
W97-1301
This confirms the high value of string matching that has been assigned to coreference resolution by previous researchers (Soon, Ng, and Lim 2001; Strube, Rapp, and Mueller 2002, among others).
C02-1139 J01-4004 P02-1014 W02-1040
As we concentrate on anaphora resolution in this article, we refer the reader to Grefenstette (1999) and Keller and Lapata (2003), as well as the December 2003 special issue of Computational Linguistics, for an overview of the use of the Web for other NLP tasks.
J03-3005
Still, about 30% of correct antecedents are not in a hyp/syn relation to their anaphor in the current case study, confirming results by Harabagiu, Bunescu, and Maiorano (2001), who also look at MUC-style corpora.
N01-1008
She also collaborated on previous related work on other-anaphora (Markert, Nissim, and Modjeska 2003; Modjeska, Markert, and Nissim 2003) on which this article builds.
W03-1023
Less attention has been paid to nominal anaphors with full lexical heads, which cover a variety of phenomena, such as coreference (Example (1)), bridging (Clark 1975; Example (2)), and comparative anaphora (Examples (3–4)).
T75-2034
This includes the extraction of hyponymy and synonymy relations (Hearst 1992; Caraballo 1999, among others) as well as meronymy (Berland and Charniak 1999; Meyer 2001).
C92-2082 P99-1008 P99-1016
Description and Annotation We use Modjeska’s (2003) annotated corpus of other-anaphors from the WSJ.
W03-1023
The integration of the Web feature in a machine-learning algorithm using several other features has yielded good results (Modjeska, Markert, and Nissim 2003).
W03-1023
Therefore, many resolution systems that handle these phenomena (Vieira and Poesio 2000; Harabagiu, Bunescu, and Maiorano 2001; Ng and Cardie 2002b; Modjeska 2002; Gardent, Manuelian, and Kow 2003, among others) rely on hand-crafted resources of lexico-semantic knowledge, such as the WordNet lexical hierarchy (Fellbaum 1998).
C02-1139 J00-4003 N01-1008 P02-1014 W03-1023
Whereas the knowledge gap might be reduced as (semi)automatic efforts to enrich ontologies become available (Hearst 1992; Berland and Charniak 1999; Poesio et al.2002), the second problem is intrinsic to fixed context-independent ontologies: How much and which knowledge should they include?
C92-2082 P99-1008
Other-anaphora are a subclass of comparative anaphora (Halliday and Hasan 1976; Webber et al.2003) in which the anaphoric NP is introduced by a lexical modifier (such as other, such, and comparative adjectives) that specifies the relationship (such as set-complement, similarity and comparison) between the entities invoked by anaphor and antecedent.
J03-4002
Therefore, the size of the corpora used in some previous approaches leads to data sparseness (Berland and Charniak 1999), and the extraction procedure can therefore require extensive smoothing.
P99-1008
Indeed, these patterns have been recently used in Web search for antecedent selection for bridging anaphora by Poesio et al.(2004). They compare accuracy in antecedent selection for a method that integrates Web hits and focusing techniques with a method that uses WordNet and focusing, achieving comparable results for both methods.
P04-1019
The Webbased algorithms could similarly benefit from the exploration of different patterns and their combination, as well as from using non-pattern-based approaches for hyponymy detection (Shinzato and Torisawa 2004).
N04-1010
The original corpus collected and annotated by Modjeska (2003) contains 500 instances of other-anaphors with NP antecedents in a five-sentence window.
W03-1023
The list-context Xs and other Ys explicitly expresses a hyponymy/synonymy relationship with X being hyponyms/synonyms of Y (see also Example (5) and [Hearst 1992]).
C92-2082
Building on our previous work (Markert, Nissim, and Modjeska 2003), we extend this corpus-based approach in two ways.
W03-1023
Modjeska. 2003.
W03-1023
The performance of these approaches on definite NPs is often substantially worse than on pronouns and/or named entities (Connolly, Burger, and Day 1997; Strube, Rapp, and Mueller 2002; Ng and Cardie 2002b; Yang et al.2003). For example, for a coreference resolution algorithm on German texts, Strube, Rapp, and Mueller (2002) report an F-measure of 33.9% for definite NPs that contrasts with 82.8% for personal pronouns.
C02-1139 P02-1014 P03-1023 W02-1040
Modjeska, Markert, and Nissim (2003) included a feature based on Web scores in a naive Bayes model for other-anaphora resolution that also used grammatical features and showed that the addition of the Web feature yielded an 11.4-percentage-point improvement over using a WordNet-based feature.
W03-1023
41 The possibility of resolving to lenient antecedents follows a similar approach as that of Ng and Cardie (2002b), who suggest a “best-first” coreference resolution approach instead of a “most recent first” approach.
C02-1139 P02-1014
40 Harabagiu, Bunescu, and Maiorano (2001) include all common-noun coreference links in their countings, whereas we concentrate on definite NPs only, so that the results are not exactly the same.
N01-1008
For such split antecedents (Modjeska 2003), the latest mention of each set member is annotated as correct, so that there can be more than one correct antecedent to an anaphor.
W03-1023
Harabagiu, Bunescu, and Maiorano (2001) (see also Kameyama 1997) report that evaluation of previous systems has shown that “more than 30% of the missed coreference links are due to the lack of semantic consistency information between the anaphoric noun and its antecedent noun” (page 59).
N01-1008 W97-1307
However, such extensive mining of the ontology (as performed, e.g., by Harabagiu, Bunescu, and Maiorano [2001]) can be costly.
N01-1008
Otherwise, we strictly followed the MUC annotation for coreference in our extraction, although it is not entirely consistent and not necessarily comprehensive (van Deemter and Kibble 2000).
J00-4005
6 Second, the antecedents of definite NP anaphora can occur at considerable distance from the anaphor, whereas antecedents to pronominal anaphora tend to be relatively close (Preiss, Gasperin, and Briscoe 2004; McCoy and Strube 1999).
W99-0108
First, whereas pronouns are mostly anaphoric in written text, definite NPs do not have to be so, inducing the problem of whether a definite NP is anaphoric in addition to determining an antecedent from among a set of potential antecedents (Fraurud 1990; Vieira and Poesio 2000).
J00-4003
approach to the extraction of instances of a particular lexical relation is the use of patterns that express lexical relations structurally explicitly in a corpus (Hearst 1992; Berland and Charniak 1999; Caraballo 1999; Meyer 2001), and this is the approach we focus on here.
C92-2082 P99-1008 P99-1016
The Knowledge Gap and Other Problems for Lexico-semantic Resources A number of previous studies (Harabagiu 1997; Kameyama 1997; Vieira and Poesio 2000; Harabagiu, Bunescu, and Maiorano 2001; Strube, Rapp, and Mueller 2002; Modjeska 2002; Gardent, Manuelian, and Kow 2003) point to the importance of lexical and world knowledge for the resolution of full NP anaphora and the lack of such knowledge in existing ontologies (Section 2.1).
J00-4003 N01-1008 W02-1040 W03-1023 W97-1307
Following our work in Markert, Nissim, and Modjeska (2003), we argue that for the task of antecedent ranking, these problems can be circumvented by not constructing a fixed ontology at all.
W03-1023
Kennedy and Boguraev (1996), Mitkov (1998), and Strube, Rapp, and Mueller (2002), for example, report accuracies of 75.0%, 89.7%, and an F-measure of 82.8% for personal pronouns, respectively.
C96-1021 P98-2143 W02-1040
