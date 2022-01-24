// See https://aka.ms/new-console-template for more information
var userRepository = new UserRepository();
userRepository.Get(1);
userRepository.GetAll();
userRepository.Create();
userRepository.Remove(1);
userRepository.Update();

var reportRepository = new ReportRepository();
reportRepository.Get(2);
reportRepository.GetAll();
