In fact, Ng and Cardie (2002a) challenged the motivation for the inclusion of such detectors, reporting no improvements, or even worse performance.
C02-1139 P02-1014
Heuristics + S1 + EHP + DO + V 79.1 84.5 Table 2: Discourse-new prediction results by Bean and Riloff coreference resolution system (specifically, the system discussed in (Ng and Cardie, 2002b)).
C02-1139 P02-1014
Vieira and Poesio (2000) proposed an algorithm for definite description resolution that incorporates a number of heuristics for detecting discourse-new (henceforth: DN) descriptions.
J00-4003
But whereas the inclusion of detectors for non-anaphoric pronouns (e.g., It in It’s raining) in algorithms such as Lappin and Leass’ (1994) leads to clear improvements in precision, the improvements in anaphoric DD resolution (as opposed to classification) brought about by the detectors were rather small.
J94-4002
A version of GUITAR without the DN detection aspects of the Vieira / Poesio algorithm was evaluated on the GNOME corpus (Poesio, 2000; Poesio et al., 2004), which contains 554 definite descriptions, of which 180 anaphoric, and 305 third-person pronouns, of which 217 anaphoric.
J00-4003 J04-3003
The baseline algorithm without DN detection incorporated in GUITAR described above (i.e., only the direct anaphora resolution part of (Vieira and Poesio, 2000)); 2.
J00-4003
The direct anaphora resolution algorithm from (Vieira and Poesio, 2000) is run, which attempts to find an head-matching antecedent within a given window and taking premodification into account.
J00-4003
GUITAR (Poesio and Alexandrov-Kabadjov, 2004) is a general-purpose anaphoric resolver that includes an implementation of the Vieira / Poesio algorithm for definite descriptions and of Mitkov’s algorithm for pronoun resolution (Mitkov, 1998).
J04-3003 J98-2001 P98-2143
The inclusion of such detectors was motivated by the observation that more than 50% of definite descriptions (DDs) in an average corpus are discourse new (Poesio and Vieira, 1998), but whereas the inclusion of detectors for non-anaphoric pronouns in algorithms such as Lappin and Leass’ (1994) leads to clear improvements in precision, the improvements in anaphoric DD resolution (as opposed to classification) brought about by the detectors were rather small.
J94-4002 J98-2001
and Cardie Ng and Cardie (2002a) directly investigate the question of whether employing a discourse-new prediction component improves the performance of a Method R P Baseline 100 72.2 Syntactic Heuristics 43 93.1 Synt.
C02-1139 P02-1014
Tetreault. 2001.
J01-4003
Preliminary Evaluations Vieira and Poesio did not test their system without DN-detection, but Ng and Cardie’s results indicate that DN detection does improve results, if not dramatically, provided that the same_head test is run first–although their DN detector does not appear to improve results for pronouns, the one category for which detection of non-anaphoricity has been shown to be essential (Lappin and Leass, 1994).
J94-4002
Uryupina (2003) trained two separate classifiers (using RIPPER, (Cohen, 1995)): a DN detector and a UNIQUENESS DETECTOR, i.e., a classifier that determines whether an NP refers to a unique object.
P03-2012
We reexamine the literature on the topic in detail, and propose a revised algorithm, taking advantage of the improved DN detection techniques developed by Uryupina (2003).
P03-2012
We re-examine the literature on the topic in detail, and propose a revised algorithm, taking advantage of the improved discourse-new detection techniques developed by Uryupina (2003).
P03-2012
Discourse-New Definite Descriptions 2.1 Vieira and Poesio Poesio and Vieira (1998) carried out corpus studies indicating that in corpora like the Wall Street Journal portion of the Penn Treebank (Marcus et al., 1993), around 52% of DDs are discourse-new (Prince, 1992), and another 15% or so are bridging references, for a total of about 66-67% firstmention.
J93-2004 J98-2001
These results led Vieira and Poesio to propose a definite description resolution algorithm incorporating independent heuristic strategies for recognizing DN definite descriptions (Vieira, 1998; Vieira and Poesio, 2000).
J00-4003
In fact, Ng and Cardie (2002a) challenged the motivation for the inclusion of such detectors, reporting no improvements or even worse performance.
C02-1139 P02-1014
Vieira and Poesio’s best result of F=77), and F=28.2 for pronouns (as opposed to results as high as F=80 obtained by the pronoun resolution algorithms evaluated in (Tetreault, 2001)).
J01-4003
Version of the System P R F Baseline 50.8 100 67.4 Discourse-new detection only 69 72 70 Hand-coded DT: partial 62 85 71.7 Hand-coded DT: total 77 77 77 ID3 75 75 75 Table 1: Overall results by Vieira and Poesio 2.2 Bean and Riloff Bean and Riloff (1999) developed a system for identifying discourse-new DDs1 that incorporates, in addition to syntax-based heuristics aimed at recognizing predicative and established DDs using postmodification heuristics similar to those used by Vieira and Poesio, additional techniques for mining from corpora unfamiliar DDs including proper names, larger situation, and semantically functional.
P99-1048
DISCOURSE-NEW DETECTORS FOR DEFINITE DESCRIPTION RESOLUTION: A SURVEY AND A PRELIMINARY PROPOSAL Massimo Poesio,† Olga Uryupina,§ Renata Vieira,∗ Mijail Alexandrov-Kabadjov† and Rodrigo Goulart∗ †University of Essex, Computer Science and Cognitive Science (UK) §Universit¨at des Saarlandes, Computerlinguistik (Germany) ∗Unisinos, Computac¸˜ao Aplicada (Brazil) Abstract Vieira and Poesio (2000) proposed an algorithm for definite description (DD) resolution that incorporates a number of heuristics for detecting discoursenew descriptions.
J00-4003
