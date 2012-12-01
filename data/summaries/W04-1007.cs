Briefly, the T&M feature set includes such features as: location of a sentence within the document and its subsections and paragraphs; sentence length; whether the sentence contains words from the title; whether it contains significant terms as determined by tf*idf ; whether it contains a citation; linguistic features of the first finite verb; and cue phrases (described as meta-discourse features in Teufel and Moens, 2002).
J02-4002
The thematic words feature in Teufel and Moens (2002) records whether a sentence contains one or more of the 18 highest scoring words.
J02-4002
Teufel and Moens (2002) describe a set of labels which reflect regularities in the argumentative structure of research articles following from the authors’ communicative goals.
J02-4002
Sentence Classifier 3.1 Feature Sets The feature set described in Teufel and Moens (2002) includes many of the features which are typically used in sentence extraction approaches to automatic summarisation as well as certain other features developed specifically for rhetorical role classification.
J02-4002
The next stage in the linguistic analysis module performs noun group and verb group chunking using fsgmatch with the specialised hand-written rule sets which were the core part of LT CHUNK (Finch and Mikheev, 1997).
A97-1054 J97-3003
The first step in the linguistic analysis module lemmatises the inflected words using Minnen et al.’s (2000) morpha lemmatiser.
W00-1427
In the SUM project, we are exploring methods for generating flexible summaries of legal documents, taking as our point of departure the Teufel and Moens (2002; 1999a; 1999b) approach to automatic summarisation (henceforth T&M).
J02-4002 W99-0311
Teufel and Moens (2002) report a macro-averaged F-score of 11 for always assigning the most frequent rhetorical class, similar to the simple baseline they use in earlier work.
J02-4002
The distribution across categories is more uniform than that of the T&M labels: Teufel and Moens (2002) report that their most frequent category (OWN) is assigned to 67% of sentences while three other labels (BASIS, TEXTUAL and AIM) are each assigned to only 2% of sentences.
J02-4002
Our preliminary cue phrase feature set includes syntactic features of the main verb (voice, tense, aspect, modality, negation), which we have shown to be correlated with rhetorical status (Grover et al., 2003).
W03-0505
We use different strategies for the identification of the two classes of entities: for the domain-specific ones we use hand-crafted LT TTT rules, while for the non-domain-specific ones we use the C&C named entity tagger (Curran and Clark, 2003) trained on the MUC7 data set.
W03-0424
First, two maximum entropy classifiers (Berger et al., 1996) are applied, where the first predicts clause start labels and the second predicts clause end labels.
J96-1002
Our working subset of the corpus is similar in size to the corpus reported in (Teufel and Moens, 2002): the T&M corpus consists of 80 conference articles while ours consists of 40 HOLJ documents.
J02-4002
The other main LT TTT program is ltpos, a statistical combined part-of-speech (POS) tagger and sentence boundary disambiguation module (Mikheev, 1997).
A97-1054 J97-3003
