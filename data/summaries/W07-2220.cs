Nivre. 2007.
D07-1096
The best performing (closed class) system in the domain adaptation track used a combination of colearningandactivelearningbytrainingtwodifferent parsers on the labeled training data, parsing the unlabeled domain data with both parsers, and adding parsed sentences to the training data only if the two parsers agreed on their analysis (Sagae and Tsujii, 2007).
D07-1111
This technique,firstproposedbySagaeandLavie(2006),was used in the highest scoring system in both the multilingual track (Hall et al., 2007a) and the domain adaptation track (Sagae and Tsujii, 2007).
D07-1097 D07-1102 D07-1111 N06-2033
The majority of these systems used models belonging to one of the twodominantapproachesindata-drivendependency parsinginrecentyears(McDonaldandNivre,2007): • In graph-based models, every possible dependency graph for a given input sentence is given a score that decomposes into scores for the arcs of the graph.
D07-1013 D07-1096
The probability model may be either conditional (Duan et al., 2007) or generative (Titov and Henderson, 2007).
D07-1098 D07-1099
The optimal parse can be found using a spanning tree algorithm (Eisner, 1996; McDonald et al., 2005).
C96-1058 H05-1066
In 2006, the shared task was multilingual dependency parsing, where participants had to train and test a parser on data from thirteen different languages (Buchholz and Marsi, 2006).
W06-2920
Another innovation was the use of k-best spanning tree algorithms for inference with a non-projective first-order model (Hall et al., 2007b).
D07-1097 D07-1102
Eisner. 1996.
C96-1058
For more information about the setup, see Nivre et al.(2007) In this paper, I will summarize the main findings from the CoNLL 2007 shared task, starting with a characterization of the different approaches used (section 2), and moving on to the most interesting results in the multilingual track (section 3) and the domain adaptation track (section 4).
D07-1096
Acknowledgments I want to thank my fellow organizers of the shared task, Johan Hall, Sandra K¨ubler, Ryan McDonald, Jens Nilsson, Sebastian Riedel, and Deniz Yuret, whoarealsoco-authorsofthelongerpaperonwhich this paper is partly based (Nivre et al., 2007).
D07-1096
The majority of graph-based parsers in the shared task were based on what McDonald and Pereira (2006) call the first-order model, where the score of each arc is independent of every other arc, but there were also attempts at exploring higher-order models, either with exact inference limited to projective dependency graphs (Carreras, 2007), or with approximate inference (Nakagawa, 2007).
E06-1011
