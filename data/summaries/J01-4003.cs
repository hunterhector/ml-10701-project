# Cb(U._~) Cb(U,,) = Cp(U,~) Continue Smooth Shift Cb(Un) = Cp(Un-1) Retain Rough Shift BFP and Walker, Iida, and Cote (1994) identified a finer gradation in the Shift transition, stating that Retains were preferred over Smooth Shifts, which were preferred over Rough Shifts.
J94-2003
As Suri, McCoy, and DeCristofaro (1999, page 180) point out: "the corpus analysis reveals how language is actually used in practice, rather than depending on a small set of discourses presented to the human subjects".
J99-2001
Strube and Hahn use Kameyama's (1998) specifications for complex sentences to break up utterances into smaller components.
P98-2204
Tetreault • University of Rochester In this paper we compare pronoun resolution algorithms and introduce a centering algorithm (LeftRight Centering) that adheres to the constraints and rules of centering theory and is an alternative to Brennan, Friedman, and Pollard's (1987) algorithm.
P87-1022
3. Evaluation of Algorithms 3.1 Data All four algorithms were compared on two domains taken from the Penn Treebank annotated corpus (Marcus, Santorini, and Marcinkiewicz 1993).
J93-2004
As an aside, the BFP algorithm can be modified (Walker 1989) so that intrasentential antecedents are given a higher preference.
P89-1031
Many hand-tested corpus evaluations have been done in the past (e.g., Walker 1989; Strube 1998; Mitkov 1998; Strube and Hahn 1999), but these have the drawback of being carried out on small corpora.
J99-3001 P89-1031 P98-2143 P98-2204
Grosz, Joshi, and Weinstein (1986, 1995) proposed the following constraints of centering theory: Constraints For each utterance Ui, in a discourse segment D, consisting of utterances of U1...
J86-3001 J95-2003
Walker (1989) compared Hobbs and BFP on three small data sets using hand evaluation.
P89-1031
We first show the attractiveness of the Left-Right Centering algorithm (henceforth LRC) (Tetreault 1999) given its incremental processing of utterances, psycholinguistic plausibility, and good performance in finding the antecedents of pronouns.
P99-1079
For example, Strube (1998) found that the S-list algorithm performed at 91% correct on three New York Times articles, while the best version of BFP performed at 81%.
P98-2204
Theory and BFP's Algorithm Centering theory is part of a larger theory of discourse structure developed by Grosz and Sidner (1986).
J86-3001
The model has one structure, the S-list, which "describes the attentional state of the hearer at any given point in processing a discourse" (Strube 1998, page 1252).
P98-2204
We follow the same method as Strube and Hahn (1999); 513 Computational Linguistics Volume 27, Number 4 that is, we first try to resolve pronouns intersententially using the BFP algorithm.
J99-3001
For all algorithms, we used the same guidelines as Strube and Hahn (1999): no world knowledge was assumed, only agreement criteria (gender, number) and binding constraints were applied.
J99-3001
512 Tetreault Centering and Pronoun Resolution 3.2 Method The evaluation (Byron and Tetreault 1999) consisted of two steps: (1) parsing Penn Treebank utterances and (2) running the four algorithms.
E99-1031 P99-1079
As described by Brennan, Friedman, and Pollard (1987) (henceforth, BFP) and Walker, Iida, and Cote (1994), entities called centers link an utterance with other utterances in the discourse segment.
J94-2003 P87-1022
This would lend support to Strube and Hahn's S-list and functional centering theories (Strube and Hahn 1996), which maintain that type of referring expression and previous mention influence the salience of each entity with the S-list or Cf-list.
P96-1036
It works by first searching for an antecedent in the current utterance; 2 if one is not found, then the previous Cf-lists (starting with the previous utterance) are searched 1 In the original S-list formulation, pronouns are not the only entities that can be marked as EVOKED; nominal anaphora and previously mentioned proper names (to name just two) can also be EVOKED (Strube and Hahn 1999).
J99-3001
The algorithm is tested against three other leading pronoun resolution algorithms: Hobbs's naive algorithm (1978), S-list (Strube 1998), and BFP (Brennan, Friedman, and Pollard 1987).
P87-1022 P98-2204
I am thankful as well for Jenny Rogers's work in annotating the fictional texts from the Penn Treebank in the same style used by Ge, Hale, and Chamiak (1998).
W98-1119
S-List Approach The third approach (Strube 1998) discards the notions of backwardand forwardlooking centers but maintains the notion of modeling the attentional state.
P98-2204
2.4 Left-Right Centering Algorithm Left-Right Centering (Tetreault 1999) is an algorithm built upon centering theory's constraints and rules as detailed in Grosz, Joshi, and Weinstein (1995).
J95-2003 P99-1079
Strube and Hahn (1996) developed a heuristic of ranking transition pairs by cost to evaluate different Cf-ranking schemes.
P96-1036
The resolution algorithm presented here comes from Strube (1998) and personal communication with Michael Strube.
P98-2204
Tetreault. 1999.
P99-1079
We depart from Walker's (1989) and Strube and Hahn's (1999) evaluations by not defining any discourse segments.
J99-3001 P89-1031
It should be noted that while BFP makes use of Rule 2 of centering theory, LRC does not since Rule 2's role in pronoun resolution is not yet known (see Kehler \[1997\] for a critique of its use by BFP).
J97-3006
6. Conclusions In this paper we first presented a new pronoun resolution algorithm, Left-Right Centering, which adheres to the constraints of centering theory and was inspired by the need to remedy a lack of incremental processing in Brennan, Friedman, and Pollard's (1987) method.
P87-1022
Unlike Walker (1989), we do not account for false positives or error chains; instead, we use a "location'-based evaluation procedure.
P89-1031
The creation of the LRC algorithm is motivated by BFP's limitation as a cognitive model in that it makes no provision for incremental resolution of pronouns (Kehler 1997).
J97-3006
The first domain consists of 3,900 utterances (1,694 unquoted pronouns) in New York Times articles provided by Ge, Hale, and Charniak (1998), who annotated the corpus with coreference information.
W98-1119
