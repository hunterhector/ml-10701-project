We converted them to dependency trees using the same method and the head table as (Bikel, 2004).
J04-4004
Many methods have been proposed to compute distributional similarity between words (Hindle, 1990; Pereira et al., 1993; Grefenstette, 1994; Lin, 1998).
P90-1034 P93-1024 P98-2127
Klein and Manning (2003) presented an unlexicalized parser that eliminated all lexicalized parameters.
P03-1054
There have been several previous approaches to parsing Chinese with the Penn Chinese Treebank (e.g., Bikel and Chiang, 2000; Levy and Manning, 2003).
P03-1056 W00-1201
We used the same data split as (Bikel, 2004): Sections 1-270 and 400-931 as 156 the training set, Sections 271-300 as testing and Sections 301-325 as the development set.
J04-4004
In many dependency parsing models such as (Eisner, 1996) and (MacDonald et al., 2005), the score of a dependency tree is the sum of the scores of the dependency links, which are computed independently of other links.
C96-1058
In the DMV model (Klein and Manning, 2004), the probability of a dependency link is partly conditioned on whether or not there is a head word of the link already has a modifier.
P04-1061
It was found in (Gildea, 2001) that the removal of bi-lexical statistics from a state-of-the-art PCFG parser resulted very small change in the output.
W01-0521
Another major difference between our model and (Clark et al., 2002) is that the parameters in our model consist exclusively of conditional probabilities of binary variables.
P02-1042
Clark et al.(2002) also computes a conditional probability of dependency structures.
P02-1042
Eisner. 1996.
C96-1058
There has been a great deal of progress in statistical parsing in the past decade (Collins, 1996; Collins, 1997; Chaniak, 2000).
P96-1025 P97-1003
Bikel (2004) observed that the bi-lexical statistics accounted for only 1.49% of the bigram statistics used by the parser.
J04-4004
Performance of Alternative Models 157 5 Related Work Previous parsing models (e.g., Collins, 1997; Charniak, 2000) maximize the joint probability P(S, T) of a sentence S and its parse tree T.
A00-2018 P97-1003
Bikel. 2004.
J04-4004
The probability ( ) 11,...,,| −ii GGSGP can be computed as: ( ) ()() ()() ()() L vL L v L v R u R u L u L u iL L v R u L u ii CvuvulinkPCvEP CuEPCuEP GGSvulinkEEEP GGSGP,,|,,|1,|,|,...,,|,,,,,...,,| 11 11 ×− ××= ¬= − − The events R w E and L w E correspond to the STOP events in (Collins, 1999) and (Klein and Manning, 2004).
P04-1061
We can compute the probability of T as follows: () () ∏ = − = = N i ii N GGSGP SGGGP STP 1 11 21,...,,| |,...,, | Following (Klein and Manning, 2004), we require that the creation of a dependency link from head h to modifier m be preceded by placing a left STOP and a right STOP around the modifier m and ¬STOP between h and m.
P04-1061
