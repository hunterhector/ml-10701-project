As one of those noun phrase chunking techniques, we propose a method for incorporating richer contextual information as well as patterns of constituent morphemes within a named entity, compared with those considered in tire previous research (Sekine et al., 1998; Borthwick, 1999), and show that the proposed method outperlbrms these approaches.
W98-1120
Next, we apply Yarowsky's method tbr supervised decision list learning I (Yarowsky, 1994) to 1VVe choose tile decision list learning method as the 705 Table 1: Statistics of NE Types of IREX NE Type ORGANIZATION PERSON LOCATION ARTIFACT DATE TIME MONEY PERCENT Total frequency (%) Training 3676 (19.7) 3840 (20.6) 5463 (29.2) 747 (4.0) 3567 (19.1) 502 (2.7) 390 (2.1) 492 (2.6) 18677 Test 361 (23.9) 338 (22.4) 413 (27.4) 48 (3.2) 260 (17.2) 54 (3.5) 15 (1.0) 21 (1.4) 1510 Japanese named entity recognition, into which we incorporate several noun phrase chunking techniques (sections 3 and 4) and experimentally evaluate their performance on the IREX, workshop's training and test data (section 5).
P94-1013
1. For each piece of evidence, we calculate the Iw of likelihood ratio of the largest; conditional probability of the decision D = :rl (given the presence of that piece of evidence) to the second largest conditional probability of the decision D =x2: I E=I) l°g2 P(D=x2 I E=I) Then~ a decision list is constructed with pieces of evidence sorted in descending order with respect to their log of likelihood ratios, where the decision of the rule at each line is D = xl with the largest conditional probability) '~Yarowsky (1994) discusses several techniques for avoiding the problems which arise when an observed count is 0.
P94-1013
In the.}al)anese language~ several recent conferences, such as MET (Multilingual Entity Task, MET-I (Maiorano, 1996) and MET-2 (MUC, 1998)) and IREX (Information letriew~l and Extraction Exercise) Workshop (IREX Committee, 1999), focused on named entity recognition ms one of their contest tasks, thus promoting research on Jat)anese named entity recognition.
X96-1050
Here we provide a basic outline of these models, and the details of how to incorporate them into the decision list learning framework will be described in Section 4.2.2. 3.a.1 3-gram Model In this paper, we refer to the model used in Sekine et al.(1998) and Borthwick (1999) as a 3-gram model.
W98-1120
Boundaries of Morphemes and Named Entities In the work presented here, we compare the segmentation boundaries of named entities in tire IREX workshop's training corpus with those of supervised learning technique mainly because it is easy to implement and quite straightibrward to extend a supervised lem'ning version to a milfimally supervised version (Collins and Singer, 1999; Cucerzan and Yarowsky, 1999).
W99-0612 W99-0613
List Learning A decision list (Rivest, 1987; Yarowsky, 1994) is a sorted list of decision rules, each of which decides the wflue of a decision D given some evidence E.
P94-1013
Finally, as in the case of previous research (Sekine et al., 1998; Berthwick, 1999), the most appropriate sequence of the decisions that are consistent throughout the whole sequence is searched for.
W98-1120
This means that the 1)roblem of recognizing named entities in those cases can be solved by incorporating techniques of base noun phrase chunking (Ramshaw and Marcus, 1995).
W95-0107
