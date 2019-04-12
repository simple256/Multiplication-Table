//
//  ViewController.swift
//  Multiplication Table
//
//  Created by Admin on 12/04/2019.
//  Copyright © 2019 Askar M. All rights reserved.
//

import UIKit

class ViewController: UIViewController, UITextFieldDelegate {

    @IBOutlet weak var textField1: UITextField?
    @IBOutlet weak var textField2: UITextField?
    @IBOutlet weak var rezLabel: UILabel!
    @IBOutlet weak var textView: UITextView!
    
    var firstValue:Int?
    var secondValue:Int?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    @IBAction func enteringFirstValue(_ sender: Any) {
        firstValue = Int(String(textField1!.text!))
        if setRezValue() {
            writeMultipleMatrix()
        }
    }
    
    @IBAction func enteringSecondValue(_ sender: Any) {
        secondValue = Int(String(textField2!.text!))
        
        if setRezValue() {
            writeMultipleMatrix()
        }
    }
    
    func setRezValue() -> Bool {
        if firstValue != nil && secondValue != nil {
            rezLabel.text = String(firstValue! * secondValue!);
            return true
        }
        return false
    }
    
    func writeMultipleMatrix(){
        textView.text = ""
        for i in 0...firstValue! {
            textView.text += String(i) + "\t"
        }
        for i in 1...secondValue! {
            textView.text += "\n"
            for j in 0...firstValue! {
                if j==0 {
                    textView.text += String(i) + "\t"
                }
                else {
                    textView.text += String(i*j) + "\t"
                }
            }
        }
    }

    
    @IBAction func hideKeyboard(_ sender: UIButton) {
        textField1!.resignFirstResponder()
        textField2!.resignFirstResponder()
    }
}

