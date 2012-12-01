In this section, we describe howwehaveusedanewsetofuserinteractionmodels (UIM) in conjunction with a relevance classifier based on conditional random fields (CRF) (McCallum, 2003; Sha and Pereira, 2003) in order to improve the relevance of the QUAB suggestions that FERRET returnsinresponsetoauser’squery.
N03-1028
theyarelookingfor. In past experiments with users of interactive Q/A systems (Hickl et al., 2004), we have found that a user’s access to sources of domain-specific knowledge significantly affects the types of questions that auserislikelytosubmittoaQ/Asystem.
W04-2508
At the core of the FERRET’s predictive dialogue moduleisthePredictiveDialogueNetwork(PQN),a largedatabaseofQUABsthatwereeithergenerated off-line by human annotators or created on-line by FERRET (either during the current dialogue or during some previous dialogue) 1. In order to generate QUABs automatically, documents identified from FERRET’s automatic Q/A system are first submitted to a Topic Representation module, which computes both topic signatures (Lin and Hovy, 2000) and enhanced topic signatures (Harabagiu, 2004) in order to identify a set of topic-relevant passages.
C00-1072 C04-1084
FERRET uses a version of LCC’s PALANTIR questionanswering system (Harabagiu et al., 2005b) in order to provide answers to questions in documents.
P05-1026
Conceptual similarity (as firstdescribedin(Harabagiuetal.,2005a))iscalculated using the version of the cosine similarity formulapresentedinFigure5.
P05-1026
Questions submitted to FERRET are initially processedbyadialogueshellwhich(1)decomposes complexquestionsintosetsofsimplerquestions(using techniques first described in (Harabagiu et al., 2005a)),(2)establishesdiscourse-levelrelationsbetween the current question and the set of questions 26 Previous Dialogue Context Management Management Dialogue Act Decomposition Question Topic Partitioning and Representation Answer Fusion Database (QUAB) Question−Answer Information Extraction Question Similarity Conversation Scenario Predictive Questions Answer Fusion Online Question Answering Off−line Question Answering Answer Question Document Collection Dialogue Shell Predictive Dialogue (PQN) Network Predictive Question Figure2: FERRET -APredictiveInteractiveQuestion-AnsweringArchitecture.
P05-1026
Inpreviouswork(Hickletal.,2004;Harabagiuet al.,2005a),wehavearguedthatinteractivequestionanswering systems should be based on a predictive dialogue architecture which can be used to provide userswithbothpreciseanswerstotheirquestionsas well as suggestions of relevant research topics that couldbeexploredthroughoutthecourseofaninteractiveQ/Adialogue.
P05-1026 W04-2508
F.ShaandF.Pereira. 2003.
N03-1028
Estimation Unlike systems that utilize mixed initiative dialogues in order to determine a user’s information needs(SmallandStrzalkowski,2004),systems(like FERRET) which rely on interactions based on predictive questioning have traditionally not incorporatedtechniquesthatallowthemtogatherrelevance feedback from users.
C04-1189
In FERRET, suggestions are made to users in the form of predictive questionanswer pairs (known as QUABs) which are either generated automatically from the set of documents returnedforaquery(usingtechniquesfirstdescribed in (Harabagiu et al., 2005a)), or are selected from a largedatabaseofquestions-answerpairscreatedoffline(priortoadialogue)byhumanannotators.
P05-1026
Passages are then submitted to an Information Extraction module, which annotates texts with a wide 1 TechniquesusedbyhumanannotatorsforcreatingQUABs were first described in (Hickl et al., 2004); full details of FERRET’sautomaticQUABgenerationcomponentsareprovidedin (Harabagiuetal.,2005a). range of lexical, semantic, and syntactic information, including (1) morphological information, (2) namedentityinformationfromLCC’s CICEROLITE named entity recognition system, (3) semantic dependencies extracted from LCC’s PropBank-style semantic parser, and (4) syntactic parse information.
P05-1026 W04-2508
(Predicate-argument relations were identified using a semanticparsertrainedonPropBank(Palmeretal.,2005)annotations.) (d)ConditionalExpectedAnswerTypelikelihood: equaltothejointprobability p(EAT QUAB |EAT question ) calculated from a corpus of dialogues collectedfromhumanusersof FERRET.
J05-1004
FERRET’s Question Similarity module then uses the similarity function described in (Harabagiu et al., 2005a) – along with relational information stored in the PQN – in order to identify the QUABs that represent the most informative possible continuations of the dialogue.
P05-1026
